﻿using BusTicket.WebAdmin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public Grade Grade { get; set; }
        public Route Route { get; set; }
        public int RouteId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
