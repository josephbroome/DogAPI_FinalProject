namespace DogAPI_FinalProject.Config
{
    public class DogAPIConfig


    {
        private const string _appSettings = "appsettings.json";

        private const string _keySection = "APIKEY";
        public static string GetKey() => GetConfigurationRoot()[_keySection];

        private static IConfigurationRoot GetConfigurationRoot() => new ConfigurationBuilder().AddJsonFile(_appSettings).Build();

    }
}
