using Newtonsoft.Json.Linq;

namespace DogAPI_FinalProject.Config
{
    public class GoogleAPIConfig
    {

        public static string GetGoogleClientID()
        {
            string key = File.ReadAllText("appsettings.json");

            string clientID = JObject.Parse(key).GetValue("ClientID").ToString();

            return clientID;
        }

        public static string GetGoogleClientSecret()
        {
            string key = File.ReadAllText("appsettings.json");

            string clientSecret = JObject.Parse(key).GetValue("ClientSecret").ToString();

            return clientSecret;

        }
    }
}
