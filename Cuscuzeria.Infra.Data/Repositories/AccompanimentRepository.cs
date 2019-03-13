using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class AccompanimentRepository : RepositoryBase<Accompaniment>, IAccompanimentRepository
    {
        public IEnumerable<Accompaniment> FindByAccompanimentName(string accompanimentname)
        {
            return Db.Accompaniments.Where(a => a.AccompanimentName == accompanimentname);
        }
    }
}