using BusTicket.WebAdmin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public int IdentityNumber { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
