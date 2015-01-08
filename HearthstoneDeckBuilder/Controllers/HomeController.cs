using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HearthstoneDeckBuilder.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         return RedirectToAction( "LetsGetToWork" ); 
      }

      public ActionResult LetsGetToWork()
      {
         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Your application description page.";

         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }
   }
}