using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;

namespace Cuscuzeria.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}