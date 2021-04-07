using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class Bus
    {
        public int BusId { get; set; }
        public string RegistrationPlate { get; set; }
        public int SeatCount { get; set; }
        public bool IsDeleted { get; set; }
    }
}
