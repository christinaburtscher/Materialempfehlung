using Materialempfehlung.Helper;
using Materialempfehlung.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Materialempfehlung.Repository
{
    public class MaterialRepository
    {
        private readonly Settings _settings;
        private readonly string _connectionString;
        private readonly string _ppConnectionString;

        public MaterialRepository()
        {
            var configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

#pragma warning disable CS8601 // Possible null reference assignment.
            _settings = configurationBuilder?.GetRequiredSection("Settings")?.Get<Settings>();
#pragma warning restore CS8601 // Possible null reference assignment.
            _settings ??= new Settings();

            var testmode = true;
            if (testmode)
            {
                _connectionString = _settings.TestConnectionString ?? string.Empty;
            }
            else
            {
                _connectionString = _settings.ProductionCariniConnectionString ?? string.Empty;
            }

            _ppConnectionString = _settings.ProductionPrintplusConnectionString ?? string.Empty;
        }

        public bool MaterialExistiert(int preisArtikel)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                var count = 0;
                string sql = $"SELECT * FROM MEL_Material WITH(NOLOCK) WHERE Preisartikel = {preisArtikel}";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }

                if (count <= 0)
                {
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        public List<MaterialVorschlag> Vorauswahl(string artikelnummer)
        {
            var materialVorschläge = new List<MaterialVorschlag>();
            using (SqlConnection connection = new(_ppConnectionString))
            {
                connection.Open();

                string sql = $"SELECT maarcod as 'Artikelnummer', maarprart as 'Preisartikel' FROM PPCARINI.dbo.T_MAAR WITH(NOLOCK) " +
                    $"WHERE maarcod like '{artikelnummer}%' " +
                    $"AND maartyp = 8 " +
                    $"AND maarprart Is NOT NULL " +
                    $"AND deleted = '0'";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var artikelNummer = reader["Artikelnummer"] as string ?? string.Empty;

                    var result = new MaterialVorschlag(StringHelper.BreiteEntfernen(artikelNummer))
                    {
                        Preisartikel = (int)reader["Preisartikel"],
                    };

                    materialVorschläge.Add(result);
                }
            }

            return materialVorschläge.DistinctBy(o => o.Preisartikel).ToList(); ;
        }

        public Material? GetByPreisartikel(int preisartikel)
        {
            var result = new Material
            {
                Preisartikel = preisartikel
            };

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"SELECT * FROM MEL_Material WITH(NOLOCK) WHERE Preisartikel = {preisartikel}";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Id = (int)reader["Id"];
                    result.Artikelnummer_Bezeichnung = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty;
                    result.Bemerkung = reader["Bemerkung"] as string ?? string.Empty;
                    result.Erstellungsdatum = (DateTime)reader["Erstellungsdatum"];
                    result.Änderungsdatum = Convert.IsDBNull(reader["Änderungsdatum"]) ? null : (DateTime?)reader["Änderungsdatum"];
                }
            }

            //ToDo get data from ppcarini
            using (SqlConnection connection = new(_ppConnectionString))
            {
                connection.Open();

                string sql = $"SELECT TOP 1 " +
                   $"MAAR.maarcod as 'Artikelnummer_Bezeichnung' " +
                   $",MAAR1.maarbez as 'Bezeichnung' " +
                   $",MAAR1.maarekp1 as 'Preis' " +
                   $",MAAR.maarlzt as 'Lieferzeit' " +
                   $",MAAR.inactive as 'Inaktiv' " +
                   $",obermaterial.alglabel as 'MAT-Qualität' " +
                   $",algstatus.alglabel as 'Status' " +
                   $",klebstoff.alglabel as 'Klebstoff' " +
                   $",farbe.alglabel as 'Farbe' " +
                   $"FROM PPCARINI.dbo.T_MAAR MAAR WITH(NOLOCK) " +
                   $"LEFT JOIN ppcarini.dbo.T_MAAR MAAR1 ON MAAR.maarprart = MAAR1.maararnr " +
                   $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as obermaterial ON MAAR1.maargrp = obermaterial.algvalue and obermaterial.algvxnr = '301' " +
                   $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as algstatus ON MAAR1.maarstat = algstatus.algvalue and algstatus.algvxnr = '300' " +
                    $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as klebstoff ON MAAR1.maarofl = klebstoff.algvalue and klebstoff.algvxnr = '311' " +
                   $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as farbe ON MAAR1.maarfrb = farbe.algvalue and farbe.algvxnr = '302' " +
                   $"WHERE MAAR.maarprart like {preisartikel} " +
                   $"AND MAAR.deleted = '0'";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var artikelnummer = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty;

                    result.Artikelnummer_Bezeichnung = StringHelper.BreiteEntfernen(artikelnummer);
                    result.Bezeichnung = reader["Bezeichnung"] as string ?? string.Empty;
                    result.Preis = (double)(decimal)reader["Preis"];
                    result.Lieferzeit = (int)reader["Lieferzeit"];
                    result.Qualität = reader["MAT-Qualität"] as string ?? string.Empty;
                    result.Status = reader["Status"] as string ?? string.Empty;
                    result.Farbe = reader["Farbe"] as string ?? string.Empty;
                    result.Klebstoff_Printplus = reader["Klebstoff"] as string ?? string.Empty;

                    var inaktiv = reader["Inaktiv"] as string ?? string.Empty;
                    if (inaktiv == "1")
                    {
                        result.Inaktiv = true;
                    }
                }
            }

            return result;
        }

        public List<Material> GetMaterialInformationen(List<int> preisartikel)
        {
            //ToDo testing 
            var materialien = new List<Material>();
            var result = new Material();

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM MEL_Material WITH(NOLOCK) WHERE Preisartikel IN ({string.Join(",", preisartikel)})";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Id = (int)reader["id"];
                    result.Artikelnummer_Bezeichnung = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty;
                    result.Bemerkung = reader["Bemerkung"] as string ?? string.Empty;
                    result.Erstellungsdatum = (DateTime)reader["Erstellungsdatum"];
                    result.Änderungsdatum = Convert.IsDBNull(reader["Änderungsdtum"]) ? null : (DateTime?)reader["Änderungsdatum"];
                    result.Preisartikel = (int)reader["Preisartikel"];

                    materialien.Add(result);
                }
            }

            foreach (var item in materialien)
            {
                using (SqlConnection connection = new(_ppConnectionString))
                {
                    connection.Open();

                    string sql = $"SELECT TOP 1 " +
                       $"MAAR.maarcod as 'Artikelnummer_Bezeichnung' " +
                       $",MAAR1.maarbez as 'Bezeichnung' " +
                       $",MAAR1.maarekp1 as 'Preis' " +
                       $",MAAR.maarlzt as 'Lieferzeit' " +
                       $",MAAR.inactive as 'Inaktiv' " +
                       $",obermaterial.alglabel as 'MAT-Qualität' " +
                       $",algstatus.alglabel as 'Status' " +
                       $",klebstoff.alglabel as 'Klebstoff' " +
                       $",farbe.alglabel as 'Farbe' " +
                       $"FROM PPCARINI.dbo.T_MAAR MAAR WITH(NOLOCK) " +
                       $"LEFT JOIN ppcarini.dbo.T_MAAR MAAR1 ON MAAR.maarprart = MAAR1.maararnr " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as obermaterial ON MAAR1.maargrp = obermaterial.algvalue and obermaterial.algvxnr = '301' " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as algstatus ON MAAR1.maarstat = algstatus.algvalue and algstatus.algvxnr = '300' " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as klebstoff ON MAAR1.maarofl = klebstoff.algvalue and klebstoff.algvxnr = '311' " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as farbe ON MAAR1.maarfrb = farbe.algvalue and farbe.algvxnr = '302' " +
                       $"WHERE MAAR.maarprart like {item.Preisartikel} " +
                       $"AND MAAR.deleted = '0'";
                    using SqlCommand command = new(sql, connection);
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var artikelnummer = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty;

                        result.Artikelnummer_Bezeichnung = StringHelper.BreiteEntfernen(artikelnummer);
                        result.Bezeichnung = reader["Bezeichnung"] as string ?? string.Empty;
                        result.Preis = (double)(decimal)reader["Preis"];
                        result.Lieferzeit = (int)reader["Lieferzeit"];
                        result.Qualität = reader["MAT-Qualität"] as string ?? string.Empty;
                        result.Status = reader["Status"] as string ?? string.Empty;
                        result.Farbe = reader["Farbe"] as string ?? string.Empty;
                        result.Klebstoff_Printplus = reader["Klebstoff"] as string ?? string.Empty;

                        var inaktiv = reader["Inaktiv"] as string ?? string.Empty;
                        if (inaktiv == "1")
                        {
                            result.Inaktiv = true;
                        }
                    }
                }
            }

            return materialien;
        }

        public List<Material> GetAll()
        {            
            var materialien = new List<Material>();
            var result = new Material();

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"SELECT * FROM MEL_Material WITH(NOLOCK)";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Id = (int)reader["id"];
                    result.Artikelnummer_Bezeichnung = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty;
                    result.Bemerkung = reader["Bemerkung"] as string ?? string.Empty;
                    result.Erstellungsdatum = (DateTime)reader["Erstellungsdatum"];
                    result.Änderungsdatum = Convert.IsDBNull(reader["Änderungsdtum"]) ? null : (DateTime?)reader["Änderungsdatum"];
                    result.Preisartikel = (int)reader["Preisartikel"];

                    materialien.Add(result);
                }
            }

            foreach (var item in materialien)
            {
                using (SqlConnection connection = new(_ppConnectionString))
                {
                    connection.Open();

                    string sql = $"SELECT TOP 1 " +
                       $"MAAR.maarcod as 'Artikelnummer_Bezeichnung' " +
                       $",MAAR1.maarbez as 'Bezeichnung' " +
                       $",MAAR1.maarekp1 as 'Preis' " +
                       $",MAAR.maarlzt as 'Lieferzeit' " +
                       $",MAAR.inactive as 'Inaktiv' " +
                       $",obermaterial.alglabel as 'MAT-Qualität' " +
                       $",algstatus.alglabel as 'Status' " +
                       $",klebstoff.alglabel as 'Klebstoff' " +
                       $",farbe.alglabel as 'Farbe' " +
                       $"FROM PPCARINI.dbo.T_MAAR MAAR WITH(NOLOCK) " +
                       $"LEFT JOIN ppcarini.dbo.T_MAAR MAAR1 ON MAAR.maarprart = MAAR1.maararnr " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as obermaterial ON MAAR1.maargrp = obermaterial.algvalue and obermaterial.algvxnr = '301' " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as algstatus ON MAAR1.maarstat = algstatus.algvalue and algstatus.algvxnr = '300' " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as klebstoff ON MAAR1.maarofl = klebstoff.algvalue and klebstoff.algvxnr = '311' " +
                       $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as farbe ON MAAR1.maarfrb = farbe.algvalue and farbe.algvxnr = '302' " +
                       $"WHERE MAAR.maarprart like {item.Preisartikel} " +
                       $"AND MAAR.deleted = '0'";
                    using SqlCommand command = new(sql, connection);
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var artikelnummer = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty;

                        result.Artikelnummer_Bezeichnung = StringHelper.BreiteEntfernen(artikelnummer);
                        result.Bezeichnung = reader["Bezeichnung"] as string ?? string.Empty;
                        result.Preis = (double)(decimal)reader["Preis"];
                        result.Lieferzeit = (int)reader["Lieferzeit"];
                        result.Qualität = reader["MAT-Qualität"] as string ?? string.Empty;
                        result.Status = reader["Status"] as string ?? string.Empty;
                        result.Farbe = reader["Farbe"] as string ?? string.Empty;
                        result.Klebstoff_Printplus = reader["Klebstoff"] as string ?? string.Empty;

                        var inaktiv = reader["Inaktiv"] as string ?? string.Empty;
                        if (inaktiv == "1")
                        {
                            result.Inaktiv = true;
                        }
                    }
                }
            }

            return materialien;
        }

        public List<string> GetByBereich(int preisartikel, string bereich)
        {
            var result = new List<string>();

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"SELECT Inhalt FROM MEL_Material2Empfehlung WITH(NOLOCK) WHERE Preisartikel = {preisartikel} AND Bereich = '{bereich}'";
                using (SqlCommand command = new(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader["Inhalt"] as string ?? string.Empty);
                        }
                    }
                }
            }

            return result;
        }

        public Material? Add(Material item)
        {
            var klebstoff = string.Empty;
            // get data from ppcarini to complete material informations
            using (SqlConnection connection = new(_ppConnectionString))
            {
                connection.Open();

                string sql = $"SELECT TOP 1 " +
                    $"MAAR.maarcod as 'Artikelnummer_Bezeichnung' " +
                    $",MAAR1.maararnr as 'Preisartikel' " +
                    $",MAAR1.maarbez as 'Bezeichnung' " +
                    $",MAAR1.maarekp1 as 'Preis' " +
                    $",MAAR.maarlzt as 'Lieferzeit' " +
                    $",MAAR.inactive as 'Inaktiv' " +
                    $",obermaterial.alglabel as 'MAT-Qualität' " +
                    $",algstatus.alglabel as 'Status' " +
                    $",klebstoff.alglabel as 'Klebstoff' " +
                    $",farbe.alglabel as 'Farbe' " +
                    $"FROM PPCARINI.dbo.T_MAAR MAAR WITH(NOLOCK) " +
                    $"LEFT JOIN ppcarini.dbo.T_MAAR MAAR1 ON MAAR.maarprart = MAAR1.maararnr " +
                    $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as obermaterial ON MAAR1.maargrp = obermaterial.algvalue and obermaterial.algvxnr = '301' " +
                    $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as algstatus ON MAAR1.maarstat = algstatus.algvalue and algstatus.algvxnr = '300' " +
                    $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as klebstoff ON MAAR1.maarofl = klebstoff.algvalue and klebstoff.algvxnr = '311' " +
                    $"LEFT JOIN PPCARINI.dbo.T_ALG10I2Y as farbe ON MAAR1.maarfrb = farbe.algvalue and farbe.algvxnr = '302' " +
                    $"WHERE MAAR.maarprart like {item.Preisartikel} " +
                    $"AND MAAR.deleted = '0'";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    item.Preisartikel = (int)reader["Preisartikel"];
                    item.Bezeichnung = reader["Bezeichnung"] as string ?? string.Empty;
                    item.Preis = (double)(decimal)reader["Preis"];
                    item.Lieferzeit = (int)reader["Lieferzeit"];
                    item.Qualität = reader["MAT-Qualität"] as string ?? string.Empty;
                    item.Status = reader["Status"] as string ?? string.Empty;
                    item.Farbe = reader["Farbe"] as string ?? string.Empty;
                    klebstoff = reader["Klebstoff"] as string ?? string.Empty;

                    var inaktiv = reader["Inaktiv"] as string ?? string.Empty;
                    if (inaktiv == "1")
                    {
                        item.Inaktiv = true;
                    }
                }
            }

            if (string.IsNullOrEmpty(item.Bezeichnung))
            {
                return null;
            }

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"INSERT INTO MEL_Material (Artikelnummer_Bezeichnung, Preisartikel, Bemerkung, Erstellungsdatum)" +
                    $" VALUES" +
                    $" ('{item.Artikelnummer_Bezeichnung}'" +
                    $",{item.Preisartikel}" +
                    $",'{item.Bemerkung}'" +
                    $",getdate()" +
                    $")";
                using SqlCommand command2 = new(sql, connection);
                var result2 = command2.ExecuteNonQuery();
                if (result2 <= 0)
                {
                    return null;
                }

                if (!AddRelation(item.Preisartikel, "Klebstoff", klebstoff))
                {
                    return null;
                };
            }

            return item;
        }

        public Material? Update(Material item)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"UPDATE MEL_Material SET " +
                    $"Bemerkung = '{item.Bemerkung}' " +
                    $",Änderungsdatum = getdate()";
                using (SqlCommand command = new(sql, connection))
                {
                    var result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        return null;
                    }
                }
            }

            // alle Daten abholen 
            var vollständigesMaterial = GetByPreisartikel(item.Preisartikel);
            return vollständigesMaterial;
        }

        public bool Delete(int preisartikel)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"DELETE FROM MEL_Material WHERE Preisartikel = {preisartikel}";
                using (SqlCommand command = new(sql, connection))
                {
                    var result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        return false;
                    }
                }
            }

            var deleteRelationResult = RemoveAllRelations(preisartikel);
            if (!deleteRelationResult)
            {
                return false;
            }

            return true;
        }

        public bool AddRelation(int preisartikel, string bereich, string inhalt)
        {
            // Material abholen
            var material = GetByPreisartikel(preisartikel);
            if (material == null)
            {
                return false;
            }

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"INSERT INTO MEL_Material2Empfehlung (Artikelnummer_Bezeichnung, Bereich, Inhalt, Preisartikel, Erstellungsdatum)" +
                    $" SELECT '{material.Artikelnummer_Bezeichnung}', '{bereich}', '{inhalt}', {preisartikel}, getdate() " +
                    $"WHERE NOT EXISTS " +
                    $"(SELECT * FROM MEL_Material2Empfehlung WHERE Preisartikel = {preisartikel} AND Bereich = '{bereich}' AND Inhalt = '{inhalt}')";
                using SqlCommand command = new(sql, connection);
                var result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool RemoveRelation(int preisartikel, string bereich, string inhalt)
        {
            // Material abholen
            var material = GetByPreisartikel(preisartikel);
            if (material == null)
            {
                return false;
            }

            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"DELETE FROM MEL_Material2Empfehlung " +
                    $"WHERE Preisartikel = {material.Preisartikel} " +
                    $"AND Bereich = '{bereich}' " +
                    $"AND Inhalt = '{inhalt}'";
                using SqlCommand command = new(sql, connection);
                var result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool RemoveAllRelations(int preisartikel)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"DELETE FROM MEL_Material2Empfehlung " +
                    $"WHERE Preisartikel = {preisartikel}";
                using SqlCommand command = new(sql, connection);
                var result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool EmpfehlungenFürBereichLöschen(string bereich, string inhalt)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"DELETE FROM MEL_Material2Empfehlung " +
                    $"WHERE Bereich = '{bereich}' " +
                    $"AND Inhalt = '{inhalt}' ";
                using SqlCommand command = new(sql, connection);
                var result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    return false;
                }
            }

            return true;
        }


        public bool EmpfehlungenLöschen(int preisartikel, string bereich, string inhalt)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string sql = $"DELETE FROM MEL_Material2Empfehlung " +
                    $"WHERE Preisartikel = {preisartikel} " +
                    $"AND Bereich = '{bereich}' " +
                    $"AND Inhalt = '{inhalt}' ";
                using SqlCommand command = new(sql, connection);
                var result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    return false;
                }
            }

            return true;
        }

        public List<int> PreisartikelFürEmpfehlungen(string bereich, string inhalt)
        {
            var result = new List<int>();
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"SELECT Preisartikel FROM MEL_Material2Empfehlung WITH(NOLOCK) WHERE Bereich = '{bereich}' AND Inhalt = '{inhalt}'";
                using (SqlCommand command = new(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = (int)reader["Preisartikel"];
                            result.Add(id);
                        }
                    }
                }
            }

            return result;
        }

        public List<Material2Empfehlung> EmpfehlungenFürPreisartikel(int preisartikel)
        {
            var result = new List<Material2Empfehlung>();
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string sql = $"SELECT * FROM MEL_Material2Empfehlung WITH(NOLOCK) WHERE Preisartikel = {preisartikel}";
                using (SqlCommand command = new(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var relation = new Material2Empfehlung
                            {
                                Preisartikel = preisartikel,
                                Artikelnummer_Bezeichnung = reader["Artikelnummer_Bezeichnung"] as string ?? string.Empty,
                                Bereich = reader["Bereich"] as string ?? string.Empty,
                                Inhalt = reader["Inhalt"] as string ?? string.Empty
                            };

                            result.Add(relation);
                        }
                    }
                }
            }

            return result;
        }
    }
}
