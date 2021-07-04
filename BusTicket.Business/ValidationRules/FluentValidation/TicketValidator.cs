using BusTicket.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TicketValidator : AbstractValidator<Ticket>
    {
        public TicketValidator()
        {
            RuleFor(t => t.SeatNumber).ExclusiveBetween(1, 50);
            RuleFor(t => t.TicketFee).GreaterThanOrEqualTo(0);
        }
    }
}
