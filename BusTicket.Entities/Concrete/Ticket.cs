using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusTicket.Entities.Concrete
{
    public class Ticket : IEntity 
    {
        public int TicketId { get; set; }
        public int SeatNumber { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Route Route { get; set; }
        public int? RouteId { get; set; }
        public int TicketFee { get; set; }
    }
}
