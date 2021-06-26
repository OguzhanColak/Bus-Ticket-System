using BusTicket.Business.Abstract;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Concrete
{
    public class ITicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        public ITicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }
        public IDataResult<List<Ticket>> GetAll()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll());
        }
        public IDataResult<List<Ticket>> GetAllByRouteId(int id)
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(x => x.RouteId == id));
        }
    }
}
