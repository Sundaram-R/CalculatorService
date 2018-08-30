using MVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitOperation(InputModel obj,string Addition, string Substraction) {

            CalculatorServiceReference.CalculatorServiceClient clien = new CalculatorServiceReference.CalculatorServiceClient();
            if (!String.IsNullOrEmpty(Addition)) {
                obj.result = clien.add(obj.value1,obj.value2);
            }
            if (!String.IsNullOrEmpty(Substraction))
            {
                obj.result = clien.substract(obj.value1, obj.value2);
            }

            return View("Index",obj);
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