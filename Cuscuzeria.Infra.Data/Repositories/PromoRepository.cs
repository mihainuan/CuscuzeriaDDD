using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class PromoRepository : RepositoryBase<Promo>, IPromoRepository
    {
        public IEnumerable<Promo> FindByPromoName(string promoname)
        {
            return Db.Promos.Where(p => p.PromoTitle == promoname);
        }
    }
}