using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Abstract
{
    interface ITicketService
    {
        List<Ticket> GetAll();
        List<Ticket> GetAllByRouteId(int id);

    }
}
