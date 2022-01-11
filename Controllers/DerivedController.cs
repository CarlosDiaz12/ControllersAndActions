using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        // GET: Derived
        public ActionResult Index()
        {
            var data = Request.Files;
            // "Hello from the DerivedController Index method"
            ViewBag.Message = data;
            return View("MyView");
        }
        /*
        public ActionResult RenameProduct()
        {
            // Access various properties from context objects
            string userName = User.Identity.Name;
            string serverName = Server.MachineName;
            string clientIP = Request.UserHostAddress;
            DateTime dateStamp = HttpContext.Timestamp;

            AuditRequest(userName, serverName, clientIP, dateStamp, "Renaming product");

            // Retrieve posted data from Request.Form
            string oldProductName = Request.Form["OldName"];
            string newProductName = Request.Form["NewName"];
            bool result = AttemptProductRename(oldProductName, newProductName);

            ViewData["RenameResult"] = result;
            return View("ProductRenamed");
        }
        */


        public ActionResult ShowWeatherForecast()
        {
            string city = (string)RouteData.Values["city"];
            DateTime forDate = DateTime.Parse(Request.Form["forDate"]);
            // ... implement weather forecast here ...
            return View();
        }

        public ActionResult ShowWeatherForecast(string city, DateTime forDate)
        {
            // ... implement weather forecast here ...
            return View();
        }

    }
}