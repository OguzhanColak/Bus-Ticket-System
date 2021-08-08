using BusTicket.Core.Utilities;
using BusTicket.Core.Utilities.Results;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Abstract
{
    public interface IRouteService
    {
        IDataResult<List<Route>> GetAll(int departureCityId, int arrivalCityId, DateTime departureTime);
        IDataResult<Route> GetById(int id);
        IResult Add(Route route);
        IResult Update(Route route);
        IResult Delete(Route route);
    }
}
