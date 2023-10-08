using RMAProject.Domain.SeedWork;
using RMAProject.Infrastructure.Repositories.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Security.Cryptography;
using RMAProject.Presentation.Services.Interfaces;

namespace RMAProject.Presentation.Services.Implementations
{
    public class SecurityService : ServiceBase, ISecurityService
    {
        public SecurityService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<Dictionary<string, string>> GenerateSaltAndHash(string password) 
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] salt = new byte[16];
            rngCsp.GetBytes(salt);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string hashedPassword = Convert.ToBase64String(hashBytes);
            return new Dictionary<string, string> 
            {
                { "salt", salt.ToString() },
                { "hashedPassword", hashedPassword}
            };
        }

    }
}
