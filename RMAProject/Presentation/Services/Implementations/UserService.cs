using RMAProject.Domain.Commands;
using RMAProject.Domain.Entities;
using RMAProject.Domain.SeedWork;
using RMAProject.Infrastructure.Repositories.Interfaces;
using RMAProject.Presentation.Services.Interfaces;

namespace RMAProject.Presentation.Services.Implementations
{
    public class UserService : ServiceBase, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ISecurityService _securityService;
        private readonly ICompanyRepository _companyRepository;

        public UserService(
                IUnitOfWork unitOfWork, 
                IUserRepository userRepository, 
                ISecurityService securityService,
                ICompanyRepository companyRepository
            ) : base(unitOfWork) 
        {
            _userRepository = userRepository;
            _securityService = securityService;
            _companyRepository = companyRepository;
        }

        public async Task RegisterUser(UserRegisterCommand command)
        {
            try
            {
                var company = _companyRepository.GetById(command.CompanyId);
                if (company == null)
                    throw new ArgumentNullException("Forneça uma empresa válida");
                var dictInfos = await _securityService.GenerateSaltAndHash(command.Password);
                var newUser = new User(command.Name, command.Email, dictInfos["salt"], dictInfos["hashedPassword"]);
                Commit();
            }
            catch (Exception e)
            { 

            }
        }
    }
}
