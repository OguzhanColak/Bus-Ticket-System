using BusTicket.WebAdmin.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Data
{
    public class BusTicketContext : DbContext
    {
        public BusTicketContext(DbContextOptions options) : base(options) { }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
