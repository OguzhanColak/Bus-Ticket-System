using BusTicket.Core.Utilities;
using BusTicket.Core.Utilities.Results;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Abstract
{
    public interface ITicketService
    {
        IDataResult<List<Ticket>> GetAll();
        IDataResult<Ticket> GetAllByRouteId(int id);
        IResult Add(Ticket ticket);
    }
}
