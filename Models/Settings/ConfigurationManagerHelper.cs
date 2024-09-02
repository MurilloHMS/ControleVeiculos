using System.Configuration;


namespace ControleVeiculos.Models.Settings
{
    internal class ConfigurationManagerHelper
    {

        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void SetSetting(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string GetConnectionString(string provider)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[provider + "Connection"];
            return connectionString?.ConnectionString;
        }

        public static void SetConnectionString(string provider, string connectionString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.ConnectionStrings.ConnectionStrings[provider + "Connection"] == null)
            {
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings
                {
                    Name = provider + "Connection",
                    ConnectionString = connectionString,
                    ProviderName = provider == "SQLite" ? "Microsoft.Data.Sqlite" : "Npgsql"
                });
            }
            else
            {
                config.ConnectionStrings.ConnectionStrings[provider + "Connection"].ConnectionString = connectionString;
            }

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void SetDatabaseProvider(string provider)
        {
            SetSetting("DatabaseProvider", provider);
        }
    }
}
