using RMAProject.Domain.Entities.Enums;
using RMAProject.Domain.Entities.GenericsEntities;

namespace RMAProject.Domain.Entities
{
    public class User : BaseClass
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int? BornDate { get; set; }
        public string HashedPassword { get; private set; }
        public string Salt { get; private set; }
        public EUserGender? UserGender { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
        public User() { }
        public User(string name, string email, string hashedPassword, string salt) 
        {
            Register();
            Name = name;
            Email = email;
            HashedPassword = hashedPassword;
            Salt = salt;
        }
    }
}
