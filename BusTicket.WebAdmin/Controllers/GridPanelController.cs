using BusTicket.WebAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Controllers
{
    public class GridPanelController : Controller
    {
        public IActionResult Index()
        {
            return View(new GridPanelModel());
        }
    }
}