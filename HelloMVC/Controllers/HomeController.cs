using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Car> cars = HelloModel.GetCars();

            ViewBag.MyValue = "Hello MVC";
            ViewBag.Cars = HelloModel.GetCars();
            return View(cars);
        }
    }
}