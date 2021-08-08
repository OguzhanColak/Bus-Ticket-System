using BusTicket.Business.Abstract;
using BusTicket.Core.Utilities;
using BusTicket.Core.Utilities.Business;
using BusTicket.Core.Utilities.Results;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Concrete
{
    public class RouteManager : IRouteService
    {
        IRouteDal _routeDal;
        public RouteManager(IRouteDal routeDal)
        {
            _routeDal = routeDal;
        }

        public IResult Add(Route route)
        {
            var result = BusinessRules.Run(
                CheckIfSameRouteAlreadyExits((int)route.DepartureCityId, (int)route.ArrivalCityId,
                route.DepartureTime, route.ArrivalTime));

            _routeDal.Add(route);
            return new SuccessResult("Sefer başarıyla eklendi.");
        }

        public IResult Delete(Route route)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Route>> GetAll(int departureCityId, int arrivalCityId, DateTime departureTime)
        {
            return new SuccessDataResult<List<Route>>(_routeDal
                .GetAll(x => x.DepartureCityId == departureCityId && x.ArrivalCityId == arrivalCityId &&
                x.DepartureTime == departureTime));
        }

        public IDataResult<Route> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Route route)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfSameRouteAlreadyExits(int departureCityId, int arrivalCityId, DateTime departureTime, DateTime arrivalTime)
        {
            var result = _routeDal.GetAll
                (x => x.DepartureCityId == departureCityId &&
                x.ArrivalCityId == arrivalCityId &&
                x.DepartureTime == departureTime &&
                x.ArrivalTime == arrivalTime).Any();

            if (result)
            {
                return new ErrorResult("Bu bilgilerde girilmiş bir sefer zaten bulunmaktadır");
            }
            return new SuccessResult();
        }
    }
}
