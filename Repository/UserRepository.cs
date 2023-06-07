using Materialempfehlung.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Materialempfehlung.Repository
{
    public class UserRepository
    {
        private readonly Settings _settings;
        public UserRepository()
        {
            var configurationBuilder = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json")
       .Build();

#pragma warning disable CS8601 // Possible null reference assignment.
            _settings = configurationBuilder?.GetRequiredSection("Settings")?.Get<Settings>();
#pragma warning restore CS8601 // Possible null reference assignment.
            _settings ??= new Settings();
        }

        public Dictionary<string, string> GetAbteilung(string username)
        {
            //ToDo check default value from Dictionary
            //get user
            var result = new Dictionary<string, string>();
            var user = string.Empty;
            var abteilung = string.Empty;
            using (SqlConnection connection = new(_settings?.ProductionPrintplusConnectionString))
            {
                connection.Open();

                string sql = $"SELECT stpsuser as 'data' FROM PPCARINI.dbo.T_STPS WHERE replace(replace(replace(replace(stpsname, 'ä', 'ae'),'ö', 'oe'),'ü','ue'),'é','e') = RIGHT('{username}', LEN('{username}') - len(left('{username}',CHARINDEX('.', '{username}')))) + ' ' + REPLACE(left('{username}',CHARINDEX('.', '{username}')-1), '-', ' ')";
                using (SqlCommand command = new(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = reader["data"] as string ?? string.Empty;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(user))
            {
                //get Abteilung
                using (SqlConnection connection = new(_settings?.ProductionPrintplusConnectionString))
                {
                    connection.Open();

                    string sql = $"SELECT TOP 1 ISNULL(iktcomm1, '')  as 'data' FROM PPCARINI.dbo.T_STPS LEFT JOIN PPCARINI.dbo.T_IVI01KTX ON stpsnachname = iktname AND stpsvorname = iktvorname AND T_IVI01KTX.deleted = 0 AND iktintnr = 1000661 WHERE T_STPS.deleted = 0 AND stpsuser = '{user}'";
                    using (SqlCommand command = new(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                abteilung = reader["data"] as string ?? string.Empty;
                            }
                        }

                        if (!string.IsNullOrEmpty(abteilung))
                        {
                            result.Add(user, abteilung);
                        }
                    }
                }
            }

            return result;
        }
    }    
}
