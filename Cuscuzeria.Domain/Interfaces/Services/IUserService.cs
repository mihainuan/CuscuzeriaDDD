using Cuscuzeria.Domain.Entities;
using System.Collections.Generic;

namespace Cuscuzeria.Domain.Services
{
    public interface IUserService : IServiceBase<User>
    {
        IEnumerable<User> FindByEmail(string email);
    }
}