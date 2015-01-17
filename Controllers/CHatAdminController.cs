using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalRChatApp.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChatApp.Controllers
{
    public class ChatAdminController : Controller
    {
        //
        // GET: /CHatAdmin/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMessage(string message)
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            hub.Clients.All.addNewMessageToPage("Admin","Molq sprete da spamite");
            TempData["message"] = "Mesage 'Molq sprete da spamite' has been send !";
            return View("index");
        }

    }
}
