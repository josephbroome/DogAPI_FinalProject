using DogAPI_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace DogAPI_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult CatGif()
        {
            return View();
        }

        public IActionResult DogGif()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ContactEmailSent()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<ActionResult> email(IFormCollection form)
        {
            var name = form["sname"];
            var email = form["semail"];
            var messages = form["smessage"];
            var phone = form["sphone"];
            var x = await SendEmail(name, email, messages, phone);
            if (x == "sent")
                ViewData["esent"] = "Your Message Has Been Sent"; //i made a new view.. so do I even need this now?
            return RedirectToAction("ContactEmailSent");
        }

        private static readonly string _emailKey = System.IO.File.ReadAllText("emailPass.txt");
        private async Task<string> SendEmail(string name, string email, string messages, string phone)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("josephlloydbroome@gamil.com")); // replace with receiver's email id
            message.From = new MailAddress($"{email}"); // replace with sender's email id     
            message.Subject = $"Message From: {email}";
            message.Body = $"Name: {name}" + //been trying to get it to provide each on their own line but it isn't working
                $"\r\n" +
                $"From: {email}" +
                $"\r\n" +
                $"Phone: {phone}" +
                $"\r\n" +
                $"{messages}";
            //message.Body = "Name: " + name + "\nFrom: " + email + "\nPhone: " + phone + "\n" + messages;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "ambertesttime@outlook.com", // replace with sender's email id     
                    Password = _emailKey // replace with password
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
                return "sent";
            }
        }

    }

}