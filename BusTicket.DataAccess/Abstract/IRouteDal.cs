using BusTicket.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Abstract
{
    public interface IRouteDal : IEntityRepository<Route>
    {
    }
}
