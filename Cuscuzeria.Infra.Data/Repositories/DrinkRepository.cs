using Cuscuzeria.Domain;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class DrinkRepository : RepositoryBase<Drink>, IDrinkRepository
    {
        public IEnumerable<Drink> FindByDrinkName(string drinkname)
        {
            return Db.Drinks.Where(d => d.DrinkName == drinkname);
        }
    }
}