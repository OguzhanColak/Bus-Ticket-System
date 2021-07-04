using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusTicket.Business.Abstract;
using BusTicket.Entities.Concrete;

namespace BusTicket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        ITicketService _ticketService;
        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            #region reflection
            var type = typeof(falan);

            falan falan = (falan)Activator.CreateInstance(type);
            #endregion

            var result = _ticketService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAllByRouteId/{id}")]
        public IActionResult GetAllByRouteId(int id)
        {
            var result = _ticketService.GetAllByRouteId(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Ticket product)
        {
            var result = _ticketService.Add(product);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }

    public class falan
    {
        public int MyProperty { get; set; }

        public string blaa()
        {
            return "";
        }
    }
}
