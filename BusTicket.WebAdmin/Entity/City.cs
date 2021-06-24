using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        [InverseProperty("DepartureCity")]
        public ICollection<Route> DepartureCityId { get; set; }
        [InverseProperty("ArrivalCity")]
        public ICollection<Route> ArrivalCityId { get; set; }
        public List<Customer> Customers { get; set; } 
    }
}
