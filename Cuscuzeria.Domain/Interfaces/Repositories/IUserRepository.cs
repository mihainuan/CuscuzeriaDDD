using Cuscuzeria.Domain.Entities;
using System.Collections.Generic;

namespace Cuscuzeria.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> FindByEmail(string email);
    }
}
