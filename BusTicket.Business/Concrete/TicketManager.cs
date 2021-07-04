using Business.ValidationRules.FluentValidation;
using BusTicket.Business.Abstract;
using BusTicket.Core.Utilities;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public IDataResult<List<Ticket>> GetAll()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll());
        }

        public IDataResult<Ticket> GetAllByRouteId(int id)
        {
            return new SuccessDataResult<Ticket>(_ticketDal.Get(x => x.RouteId == id));
        }

        [ValidationAspect(typeof(TicketValidator))]
        public IResult Add(Ticket product)
        {
            _ticketDal.Add(product);

            return new SuccessResult("Bilet başarıyla alındı.");
        }
    }
}
