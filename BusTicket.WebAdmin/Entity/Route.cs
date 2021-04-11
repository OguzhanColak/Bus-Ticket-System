using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class Route // Sefer
    {
        public int RouteId { get; set; }
        public int DepartureCityId { get; set; } //KalkışŞehirId
        public int ArrivalCityId { get; set; } //VarışŞehirId
        public int BusId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime{ get; set; }
        public int TicketFee { get; set; }

    }
}
