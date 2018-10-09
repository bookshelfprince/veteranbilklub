using ClientSideProgramming.DBActions;
using ClientSideProgramming.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;

namespace ClientSideProgramming.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public ActionResult Members() => View();

        public ActionResult Cars() => View();

        public ActionResult Spareparts() => View();

        public ActionResult DashboardCars() => View();

        [HttpPost]
        public void SaveToDatabase(Car model)
        {
            Car car = new Car()
            {
                Name = model.Name,
                Year = model.Year,
                Manufactor = model.Manufactor,
                Image = model.Image

            };

            CarDB carDB = new CarDB();
            carDB.AddCar(car, User.Identity.GetUserName());
        }
        [HttpPost]
        public void DeleteCar(Car car)
        {
            Car newCar = new Car
            {
                Name = car.Name,
                Image = car.Image,
                Year = car.Year,
                Manufactor = car.Manufactor
            };

            CarDB carDB = new CarDB();
            carDB.DeleteCar(newCar, User.Identity.GetUserName());
        }
        public ActionResult LoggedIn()
        {
            if (User.Identity.IsAuthenticated)
                return View("Dashboard");
            else
                return View("Login");
        }
        public ActionResult Dashboard()
        {
            if (User.Identity.IsAuthenticated)
                return View("Dashboard");
            else
                return View("Login");
        }
    }
}