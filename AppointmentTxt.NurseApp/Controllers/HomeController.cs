using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppointmentTxt.NurseApp.Models;
using Microsoft.AspNet.SignalR.Client;

namespace AppointmentTxt.NurseApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public void PostTxtMessage(TxtMessageModel model)
        {


            string line = "";

            // Connect to the service
            var connection = new Connection("http://localhost/AppointmentTxt.NurseApp/echo");

            // Start the connection
            connection.Start().Wait();

            // Send a message to the server
            connection.Send(line).Wait();
        
        }
    }
}
