using BusTicket.DataAccess.Concrete.EntityFramework;
using BusTicket.WebAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using MojeeIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Controllers
{
    public class AddExpeditionController : Controller
    {
        private readonly BusTicketContext _context;
        public AddExpeditionController(BusTicketContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult merhaba()
        {
            return View("<h1>Sefer başarıyla eklendi.</h1>");
        }

        [HttpPost]
        public IActionResult getCityValues()
        {
            //var cityName = route;
            //var dcity = Request.Form["Dcity"];
            //var acity = Request.Form["Acity"];

            #region Silme

            var entity = _context.Routes.Find(6);
            //_context.Routes.Remove(entity);
            //_context.SaveChanges();

            #endregion


            //var newBus = new Entity.Bus
            //{
            //    IsDeleted = false,
            //    RegistrationPlate = "34 AGY 546",
            //    SeatCount = 42
            //};

            //_context.Buses.Add(newBus);
            //_context.SaveChanges();



            //var newCity = new Entity.City { CityName = "Edirne" };
            //var newCity2 = new Entity.City { CityName = "İstanbul" };
            //var cityList = new List<Entity.City> { newCity, newCity2 };

            //_context.Cities.AddRange(cityList);
            //_context.SaveChanges();

            //var newRoute = new Entity.Route
            //{
            //    ArrivalCityId = 1,
            //    ArrivalTime = DateTime.Now,
            //    BusId = 1,
            //    DepartureCityId = 2,
            //    DepartureTime = DateTime.Now,
            //};

            //_context.Routes.Add(newRoute);
            //_context.SaveChanges();
            
            
            

            return RedirectToAction("merhaba");
        }
    }

    
}
