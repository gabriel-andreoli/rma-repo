using RMAProject.Domain.Commands;

namespace RMAProject.Presentation.Services.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(UserRegisterCommand command);
    }
}
