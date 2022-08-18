using Newtonsoft.Json.Linq;
using RestSharp;
using Ubiety.Dns.Core;

namespace DogAPI_FinalProject.Models
{
    public class GetDogsByBreedResponse
    {
        public List<DogAPIResponse> Dogs { get; set; } = new List<DogAPIResponse>();

        public GetDogsByBreedResponse()
        {

        }

        public GetDogsByBreedResponse(RestResponse apiresponse)
        {
            var breeds = JArray.Parse(apiresponse.Content);

            if (breeds != null)
            {


                Dogs = breeds.Select(x =>
                {
                    JObject breed = (JObject)x;
                    return new DogAPIResponse()
                    {
                        DogBreed = breed.GetValue("name")?.ToString(),

                        DogWeight = breed.GetValue("weight")?.SelectToken("imperial").ToString(),

                        DogHeight = breed.GetValue("height")?.SelectToken("imperial").ToString(),

                        BredFor = breed.GetValue("bred_for")?.ToString(),

                        BreedGroup = breed.GetValue("breed_group")?.ToString(),

                        LifeSpan = breed.GetValue("life_span")?.ToString(),

                        Temperament = breed.GetValue("temperament")?.ToString(),

                        ImageID = breed.GetValue("reference_image_id")?.ToString(),

                    };
                }).ToList();
            }

        }

    }
}

