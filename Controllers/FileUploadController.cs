using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.IO;
using System.Web;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;

namespace DogAPI_FinalProject.Controllers
{
    public class FileUploadController : Controller
    {

        private readonly string _uploaded = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploaded");

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile formFile)
        {
            if (formFile != null)
            {
                var path = Path.Combine(_uploaded, Guid.NewGuid() + Path.GetExtension(formFile.FileName));

                using var stream = new FileStream(path, FileMode.Create);
                await formFile.CopyToAsync(stream);

            }
            return RedirectToAction("_Layout","Shared");
        }









    }



}   

