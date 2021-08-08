using BusTicket.Business.Abstract;
using BusTicket.Business.ValidationRules.FluentValidation;
using BusTicket.Core.Aspects.Autofac.Validation;
using BusTicket.Core.Utilities;
using BusTicket.Core.Utilities.Business;
using BusTicket.Core.Utilities.Results;
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
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        ICustomerService _customerService;
        public TicketManager(ITicketDal ticketDal, ICustomerService customerService)
        {
            _ticketDal = ticketDal;
            _customerService = customerService;
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
        public IResult Add(Ticket ticket)
        {
            IResult result = BusinessRules.Run(CheckIfCustomerSurnameAlreadyExits(ticket.Customer.Surname));

            if (result != null)
            {
                return result;
            }

            _ticketDal.Add(ticket);

            return new SuccessResult("Bilet başarıyla alındı.");
        }

        private IResult CheckIfCustomerSurnameAlreadyExits(string surname)
        {
            var result = _customerService.GetAll().Data.Where(x => x.Surname == surname).Any();
            
            if (result)
            {
                return new ErrorResult("Aynı soyadda bir müşteri zaten var");
            }
            return new SuccessResult();
        }
    }
}
