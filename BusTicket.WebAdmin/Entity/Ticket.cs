using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int SeatNumber { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Route Route { get; set; }
        public int? RouteId { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public int TicketFee { get; set; }
    }
}
