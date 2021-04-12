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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult merhaba()
        {
            this.X().Toast(Mojee.Replace("Menü Item'a tıklandı!1!11"));

            return this.Direct();
        }
    }
}
