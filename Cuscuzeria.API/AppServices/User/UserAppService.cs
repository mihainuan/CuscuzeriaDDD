using Cuscuzeria.API.Interface;
using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Services;
using System.Collections.Generic;

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

        public IEnumerable<User> FindByEmail(string email)
        {
            return _userService.FindByEmail(email);
        }
    }
}