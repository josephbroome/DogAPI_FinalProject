using DogAPI_FinalProject.Config;
using DogAPI_FinalProject.Models;
using Microsoft.VisualStudio.Core.Imaging;
using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;
using System.Data;
using System.Xml.Linq;

namespace DogAPI_FinalProject
{
    public class DogAPIclient
    {
        private readonly string _key;

        private readonly string _baseurl = "https://api.thedogapi.com/v1/breeds";
        public DogAPIclient()
        {
            _key = DogAPIConfig.GetKey();

        }

        private RestClient GetClient(string route)
        {
            return new RestClient(route);

        }

        private RestResponse GetResponse(string route)
        {
            var request = new RestRequest();

            request.AddHeader($"x-api-key", $"{_key}");

            return GetClient(route).Execute(request);

        }


        public RestResponse GetDogBreeds() => GetResponse(_baseurl);


        public RestResponse GetDogByBreed(string breed) => GetResponse($"https://api.thedogapi.com/v1/breeds/search?q={breed}");


        public RestResponse GetDogImage(string ImageID) => GetResponse($"https://cdn2.thedogapi.com/images/{ImageID}.jpg");

      
       

        //public RestResponse GetDogImage()

    }
}
