using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entities.Concrete
{
    public class Route : IEntity
    {
        public int RouteId { get; set; }

        [ForeignKey("DepartureCity")]
        public int? DepartureCityId { get; set; }
        public City DepartureCity { get; set; } //KalkışŞehirId

        [ForeignKey("ArrivalCity")]
        public int? ArrivalCityId { get; set; }
        public City ArrivalCity { get; set; } //VarışŞehirId

        public List<Ticket> Tickets { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
