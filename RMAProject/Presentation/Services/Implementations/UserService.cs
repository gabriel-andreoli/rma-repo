using RMAProject.Domain.Commands;
using RMAProject.Infrastructure.Repositories.Interfaces;
using RMAProject.Presentation.Services.Interfaces;

namespace RMAProject.Presentation.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(UserRegisterCommand command)
        {
        }
    }
}
