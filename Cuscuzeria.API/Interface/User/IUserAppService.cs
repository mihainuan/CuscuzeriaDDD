using Cuscuzeria.Domain.Entities;
using System.Collections.Generic;

namespace Cuscuzeria.API.Interface
{
    public interface IUserAppService : IAppServiceBase<User>
    {
        IEnumerable<User> FindByEmail(string email);
    }
}