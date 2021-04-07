using BusTicket.WebAdmin.Models;
using Ext.Net;
using Ext.Net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MojeeIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Controllers
{
    public class DirectEventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ButtonClick()
        {
            var msg = $"Server Time is { DateTime.Now.ToString("H:mm:ss tt") } :+1:";

            this.X().Toast(Mojee.Replace(msg));

            return this.Direct();
        }
    }
}