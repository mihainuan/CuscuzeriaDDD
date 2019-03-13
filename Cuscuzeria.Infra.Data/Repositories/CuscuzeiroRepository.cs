using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class CuscuzeiroRepository : RepositoryBase<Cuscuzeiro>, ICuscuzeiroRepository
    {
        public IEnumerable<Cuscuzeiro> FindByCuscuzeiroName(string cuscuzeironame)
        {
            return Db.Cuscuzeiros.Where(co => co.CuscuzeiroName == cuscuzeironame);
        }
    }
}