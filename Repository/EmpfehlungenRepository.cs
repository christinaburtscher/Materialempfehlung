using Materialempfehlung.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Materialempfehlung.Repository
{
    public class EmpfehlungenRepository
    {
        private readonly Settings _settings;

        public EmpfehlungenRepository()
        {
            var configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

#pragma warning disable CS8601 // Possible null reference assignment.
            _settings = configurationBuilder?.GetRequiredSection("Settings")?.Get<Settings>();
#pragma warning restore CS8601 // Possible null reference assignment.
            _settings ??= new Settings();          
        }

        public Dictionary<string, IList<string>> GetAllForOverview(string bereich)
        {
            var empfehlungen = new Dictionary<string, IList<string>>();
            var resultList = new List<string>();

            using (SqlConnection connection = new(_settings?.TestConnectionString))
            {
                connection.Open();

                string sql = $"SELECT Inhalt FROM MEL_Empfehlung WITH(NOLOCK)" +
                    $"WHERE Bereich = '{bereich}'";
                using (SqlCommand command = new(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultList.Add(reader["Inhalt"] as string ?? string.Empty);
                        }
                    }
                }
            }

            empfehlungen.Add(bereich, resultList);
            return empfehlungen;
        }

        public bool Hinzufügen(string bereich, string inhalt, string bemerkung)
        {
            using (SqlConnection connection = new(_settings?.TestConnectionString))
            {
                connection.Open();
              
                string sql = $"INSERT INTO MEL_Empfehlung " +
                    $"(Bereich, Inhalt, Bemerkung, Erstellungsdatum) " +
                    $"SELECT '{bereich}', '{inhalt}', '{bemerkung}', getdate() " +
                    $"WHERE NOT EXISTS " +
                    $"(SELECT * FROM MEL_Empfehlung WHERE Bereich = '{bereich}' AND Inhalt = '{inhalt}')";
                using (SqlCommand command = new(sql, connection))
                {
                    var result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Update(string bereich, string inhalt, string bemerkung)
        {
            using (SqlConnection connection = new(_settings?.ProductionPrintplusConnectionString))
            {
                connection.Open();

                string sql = $"UPDATE MEL_Empfehlung SET " +
                    $",Bemerkung = '{bemerkung}'" +
                    $",Änderungsdatum = getdate()" +
                    $"WHERE Bereich = '{bereich}'" +
                    $"AND Inhalt = '{inhalt}'";
                using (SqlCommand command = new(sql, connection))
                {
                    var result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Delete(string bereich, string inhalt)
        {
            using (SqlConnection connection = new(_settings?.TestConnectionString))
            {
                connection.Open();

                string sql = $"DELETE FROM MEL_Empfehlung " +
                    $"WHERE Bereich = '{bereich}'" +
                    $"AND Inhalt = '{inhalt}'";
                using (SqlCommand command = new(sql, connection))
                {
                    var result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public Dictionary<string, List<string>> GetAll()
        {
            List<Tuple<string, string>> empfehlungen = new List<Tuple<string, string>>();
            var resultList = new List<string>();

            using (SqlConnection connection = new(_settings?.TestConnectionString))
            {
                connection.Open();

                string sql = $"SELECT Bereich, Inhalt FROM MEL_Empfehlung WITH(NOLOCK)";
                using (SqlCommand command = new(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bereich = reader["Bereich"] as string ?? string.Empty;
                            var inhalt = reader["Inhalt"] as string ?? string.Empty;

                            empfehlungen.Add(new Tuple<string, string>(bereich, inhalt));
                        }
                    }
                }
            }

            var gruppierteEmpfehlungen = empfehlungen.GroupBy(o => o.Item1).ToDictionary(key => key.Key, value => value.Select(i => i.Item2).ToList());
            return gruppierteEmpfehlungen;
        }
    }
}
