using BusTicket.WebAdmin.Data;
using Ext.Net.Core;
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
            this.X().Toast(Mojee.Replace("Sefer eklendi."));
            return this.Direct();
        }

        [HttpPost]
        public IActionResult getCityValues(Entity.Route route)
        {
            var cityName = route;
            var dcity = Request.Form["Dcity"];
            var acity = Request.Form["Acity"];

            _context.Routes.Add(route);
            _context.SaveChanges();




            return RedirectToAction("merhaba");
        }
    }
}
