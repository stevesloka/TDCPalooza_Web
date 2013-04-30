using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppointmentTxt.NurseApp.Models;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;

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
            var host = ConfigurationManager.AppSettings["SiteURL"];

            // Connect to the service
            var hubConnection = new HubConnection(host);

            // Create a proxy to the chat service
            var chat = hubConnection.CreateHubProxy("chat");

            // Start the connection
            hubConnection.Start().Wait();

            string line = string.Format("Received message from: {0} - {1} Msg[{2}]", model.From, model.FromCity, model.Body);

            // Send a message to the server
            chat.Invoke("Send", line).Wait();
        }
    }
}
