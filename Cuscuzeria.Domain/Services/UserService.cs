using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;
using System.Collections.Generic;

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

        public IEnumerable<User> FindByEmail(string email)
        {
            return _userRepository.FindByEmail(email);
        }
    }
}