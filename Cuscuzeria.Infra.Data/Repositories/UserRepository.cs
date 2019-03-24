using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> FindByEmail(string email)
        {
            return Db.Users.Where(u => u.Email == email);
        }
    }
}
