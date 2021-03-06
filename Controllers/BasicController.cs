using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string controller = (string)requestContext.RouteData.Values["controller"];
            string action = (string)requestContext.RouteData.Values["action"];
            string data = requestContext.HttpContext.Request.UserHostAddress;
            var addData = requestContext.HttpContext.Request.ServerVariables["HTTP_HOST"];


            if (action.ToLower() == "redirect")
            {
                requestContext.HttpContext.Response.Redirect("/Derived/Index");
            }
            else
            {
                requestContext.HttpContext.Response.Write(string.Format("Controller: {0}, Action: {1}", controller, action));
            }

            // requestContext.HttpContext.Response.Write(string.Format("Data: {0}",addData ));
            // requestContext.HttpContext.Response.Write(string.Format("Controller: {0}, Action: {1}", controller, action));
        }
    }
}