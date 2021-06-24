using BusTicket.Core.DataAccess.EntityFramework;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityReposityoryBase<City, BusTicketContext>, ICityDal
    {
        
    }
}
