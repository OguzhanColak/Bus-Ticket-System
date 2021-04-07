using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class Ticket
    {
        public int SeatNumber { get; set; }
        public int CustomerId { get; set; }
        public int ExpeditionId { get; set; } 
        public int EmployeeId { get; set; } 
    }
}
