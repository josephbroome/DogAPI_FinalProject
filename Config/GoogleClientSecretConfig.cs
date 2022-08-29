namespace DogAPI_FinalProject.Config
{
    public class GoogleClientSecretConfig
    {
        private const string _appSettings = "appsettings.json";

        private const string _keySection = "ClientSecret";
        public static string GetGoogleClientSecret() => GetConfigurationRoot()[_keySection];

        private static IConfigurationRoot GetConfigurationRoot() => new ConfigurationBuilder().AddJsonFile(_appSettings).Build();

    }
}
