using BusTicket.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework
{
    public class BusTicketContext : DbContext
    {
        //public BusTicketContext(DbContextOptions options) : base(options) { }
        //public BusTicketContext(DbContextOptions<BusTicketContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database=BusTicket;Trusted_Connection=true");

        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
