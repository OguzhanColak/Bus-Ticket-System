using BusTicket.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Abstract
{
    interface ITicketService
    {
        IDataResult<List<Ticket>> GetAll();
        IDataResult<List<Ticket>> GetAllByRouteId(int id);

    }
}
