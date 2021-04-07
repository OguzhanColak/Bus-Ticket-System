using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Models
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; } 
        public bool IsManager { get; set; }
        public bool IsLogin { get; set; }
        public DateTime OperationTime { get; set; }
        public string PersonalOperation { get; set; }
    }
}
