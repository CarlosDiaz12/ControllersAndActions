using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            DateTime time = (DateTime)TempData.Peek("Date");
            // You can preserve a value that would otherwise be deleted by using the "Keep" method
            TempData.Keep("Date");
            return View("HomePage");
        }

        public HttpStatusCodeResult StatusCode()
        {
            // return HttpNotFound();
            // return new HttpUnauthorizedResult();
            return new HttpStatusCodeResult(404, "URL cannot be serviced");
        }

        public RedirectToRouteResult Redirect()
        {
           // return RedirectToAction("Index"); 
            return RedirectToRoute(new
            {
                controller = "Example",
                action = "Index",
                ID = "MyID"
            });
        }

        public RedirectToRouteResult RedirectToRoute()
        {
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }

    }
}