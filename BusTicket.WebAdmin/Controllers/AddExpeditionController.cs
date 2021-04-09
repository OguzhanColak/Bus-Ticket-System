using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Controllers
{
    public class AddExpeditionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
