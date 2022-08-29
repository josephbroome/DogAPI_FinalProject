using Newtonsoft.Json.Linq;

namespace DogAPI_FinalProject.Config
{
    public class GoogleClientIdConfig
    {

        //public static string GetGoogleClientID()
        //{
        //    string key = File.ReadAllText("appsettings.json");

        //    string clientID = JObject.Parse(key).GetValue("ClientID").ToString();

        //    return clientID;
        //}

        //public static string GetGoogleClientSecret()
        //{
        //    string key = File.ReadAllText("appsettings.json");

        //    string clientSecret = JObject.Parse(key).GetValue("ClientSecret").ToString();

        //    return clientSecret;

        //}

        private const string _appSettings = "appsettings.json";
        
        private const string _keySection = "ClientID";
        public static string GetGoogleCLientId() => GetConfigurationRoot()[_keySection];

        private static IConfigurationRoot GetConfigurationRoot() => new ConfigurationBuilder().AddJsonFile(_appSettings).Build();

    }
}
