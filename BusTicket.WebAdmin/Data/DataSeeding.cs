using BusTicket.WebAdmin.Entity;
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

            context.Database.Migrate(); // dotnet ef database update

            var buses = new List<Bus>()
            { 
                new Bus {RegistrationPlate="34 AA 234", SeatCount= 30, IsDeleted= false},            
                new Bus {RegistrationPlate="22 HA 247", SeatCount= 40, IsDeleted= false},            
                new Bus {RegistrationPlate="34 AA 084", SeatCount= 27, IsDeleted= false},           
                new Bus {RegistrationPlate="55 AA 954", SeatCount= 45, IsDeleted= false}            
            };

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
                    Gender=(Enums.Gender)1, 
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

            var employees = new List<Employee>()
            { 
                new Employee
                {
                    Email="hayri@gmail.com",
                    RouteId=1,
                    Grade=Enums.Grade.Manager,
                    IsDeleted=false,
                    Name="Hayri",
                    Surname="Yazıcı",
                    PhoneNumber="0546873164",
                    Username="hayri22",
                    Password="22hayri",
                },
                new Employee
                {
                    Email="yaşar@gmail.com",
                    RouteId=1,
                    Grade=Enums.Grade.Employee,
                    IsDeleted=false,
                    Name="Yaşar",
                    Surname="Kuruk",
                    PhoneNumber="0546873164",
                    Username="yaşar22",
                    Password="22yaşar",
                },
                new Employee
                {
                    Email="süleyman@gmail.com",
                    RouteId=1,
                    Grade=Enums.Grade.Employee,
                    IsDeleted=false,
                    Name="Süleyman",
                    Surname="Yenici",
                    PhoneNumber="0546873164",
                    Username="süleyman22",
                    Password="22süleyman",
                }
            };

            var routes = new List<Route>()
            {
                new Route
                {
                    ArrivalCityId=0,
                    ArrivalTime=DateTime.Now,
                    BusId=0,
                    DepartureCityId=1,
                    DepartureTime=DateTime.Now,
                    TicketFee=200
                },
                new Route
                {
                    ArrivalCityId=1,
                    ArrivalTime=DateTime.Now,
                    BusId=1,
                    DepartureCityId=2,
                    DepartureTime=DateTime.Now,
                    TicketFee=150
                },
                new Route
                {
                    ArrivalCityId=2,
                    ArrivalTime=DateTime.Now,
                    BusId=1,
                    DepartureCityId=3,
                    DepartureTime=DateTime.Now,
                    TicketFee=90
                }
            };

            var systemUsers = new List<SystemUser>() 
            {
                new SystemUser
                {
                    Email= "oguzhan@gmail.com",
                    IsDeleted= false,
                    IsManager = true,
                    OperationTime = DateTime.Now,
                    PersonalOperation = "Giriş Yaptı", // bu prop kaldırılabilir.
                    Username = "oguzhan22",
                    Password = "22oguzhan"
                },
                new SystemUser
                {
                    Email= "talha@gmail.com",
                    IsDeleted= false,
                    IsManager = true,
                    OperationTime = DateTime.Now,
                    PersonalOperation = "Giriş Yaptı", // bu prop kaldırılabilir.
                    Username = "talha22",
                    Password = "22talha"
                }
            };

            var tickets = new List<Ticket>()
            {
                new Ticket
                {
                    CustomerId = customers[0].CustomerId,
                    EmployeeId = employees[0].EmployeeId,
                    RouteId = routes[0].RouteId,
                    SeatNumber = 5
                },
                new Ticket
                {
                    CustomerId = customers[1].CustomerId,
                    EmployeeId = employees[0].EmployeeId,
                    RouteId = routes[0].RouteId,
                    SeatNumber = 15
                }
            };
        }
    }
}
