using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class BeverageRepository : RepositoryBase<Beverage>, IBeverageRepository
    {
        public IEnumerable<Beverage> FindByBeverageName(string beveragename)
        {
            return Db.Beverages.Where(b => b.BeverageName == beveragename);
        }
    }
}