using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class CuscuzRepository : RepositoryBase<Cuscuz>, ICuscuzRepository
    {
        public IEnumerable<Cuscuz> FindByCuscuzName(string cuscuzname)
        {
            return Db.Cuscuz.Where(cu => cu.CuscuzName == cuscuzname);
        }
    }
}