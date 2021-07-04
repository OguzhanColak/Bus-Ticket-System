using BusTicket.DataAccess.Concrete.EntityFramework;
using BusTicket.Entities.Concrete;
using BusTicket.Entities.Concrete.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.WebAdmin.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app) 
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<BusTicketContext>();

            //context.Cities.AddRange(cities);

            //context.Database.Migrate(); // dotnet ef database update

            var cities = new List<City>()
            {
                new City {CityName="Edirne"},
                new City {CityName="İstanbul"},
                new City {CityName="Samsun"},
                new City {CityName="Ankara"}
            };

            var customers = new List<Customer>()
            {
                new Customer
                {
                    Address="Merkez/Edirne",
                    Birthdate=DateTime.Now,
                    CityId=1,
                    Email="ayse@gmail.com",
                    Gender=(Gender)1,
                    Name="Ayşe",
                    PhoneNumber="05367314654",
                    Surname="Çelik"
                },
                new Customer
                {
                    Address="Atakum/Samsun",
                    Birthdate=DateTime.Now,
                    CityId=2,
                    Email="hakan@gmail.com",
                    Gender=0, // Gender = Enums.Gender.Male
                    Name="Hakan",
                    PhoneNumber="05764542421",
                    Surname="Hakan Yavuz"
                }
            };


            var routes = new List<Route>()
            {
                new Route
                {
                    ArrivalCityId=0,
                    ArrivalTime=DateTime.Now,
                    DepartureCityId=1,
                    DepartureTime=DateTime.Now,
                },
                new Route
                {
                    ArrivalCityId=1,
                    ArrivalTime=DateTime.Now,
                    DepartureCityId=2,
                    DepartureTime=DateTime.Now,
                },
                new Route
                {
                    ArrivalCityId=2,
                    ArrivalTime=DateTime.Now,
                    DepartureCityId=3,
                    DepartureTime=DateTime.Now,
                }
            };


            var tickets = new List<Ticket>()
            {
                new Ticket
                {
                    CustomerId = customers[0].CustomerId,
                    RouteId = routes[0].RouteId,
                    SeatNumber = 5,
                    TicketFee = 250
                },
                new Ticket
                {
                    CustomerId = customers[1].CustomerId,
                    RouteId = routes[0].RouteId,
                    SeatNumber = 15,
                    TicketFee = 170
                }
            };


            context.Cities.AddRange(cities);

            context.Database.Migrate();
        }
    }
}
