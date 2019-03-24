using Cuscuzeria.API.Interface;
using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Services;

namespace Cuscuzeria.API
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
            : base(userService)
        {
            _userService = userService;
        }

    }
}