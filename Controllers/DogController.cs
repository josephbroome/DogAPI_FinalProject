using DogAPI_FinalProject.Config;
using DogAPI_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace DogAPI_FinalProject.Controllers
{
    public class DogController : Controller
    {


        private readonly DogAPIclient _client;

        public DogController(DogAPIclient client)
        {
                _client = client;   
        }


        public IActionResult GetDogByBreed(string breed)
        {
            var response = _client.GetDogByBreed(breed);

            return View(new GetDogsByBreedResponse(response));

        
        }

        public IActionResult GetDogBreeds()
        {
            var breeds = _client.GetDogBreeds();

            return View(new GetDogBreedsResponse(breeds));
        }

        //public IActionResult GetDogImage(string ImageID)
        //{
        //    var image = _client.GetDogImage(ImageID);

        //    return View(new GetDogImageResponse(image));

        //}

    }
}
