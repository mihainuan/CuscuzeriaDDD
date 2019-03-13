using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class TypeRepository : RepositoryBase<Type>, ITypeRepository
    {
        public IEnumerable<Type> FindByTypeName(string typename)
        {
            return Db.Types.Where(t => t.TypeName == typename);
        }
    }
}