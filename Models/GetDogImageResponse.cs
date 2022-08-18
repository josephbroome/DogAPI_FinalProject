using RestSharp;
using Newtonsoft.Json.Linq;
using Microsoft.VisualStudio.Core.Imaging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DogAPI_FinalProject.Models
{
    public class GetDogImageResponse
    {
        public GetDogImageResponse()
        {


        }

        public List<DogAPIResponse> Dogs { get; set; } = new List<DogAPIResponse>();
        public string ImageID { get; }

        public GetDogImageResponse(RestResponse apiresponse)
        {
            var breeds = JArray.Parse(apiresponse.ContentType);
            string myimage = "";
            if (breeds != null)
            {


                Dogs = breeds.Select(x =>
                {
                    JObject breed = (JObject)x;
                    return new DogAPIResponse()
                    {


                        ImageID = breed.GetValue("reference_image_id")?.ToString(),

                    


                    };
                }).ToList();
            }

        }

        public GetDogImageResponse(string imageID)
        {
            ImageID = imageID;
        }
    }
}
