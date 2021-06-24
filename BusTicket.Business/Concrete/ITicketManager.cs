using BusTicket.Business.Abstract;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
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
        public List<Ticket> GetAll()
        {
            return _ticketDal.GetAll();
        }
        public List<Ticket> GetAllByRouteId(int id)
        {
            return _ticketDal.GetAll(x => x.RouteId == id);
        }
    }
}
