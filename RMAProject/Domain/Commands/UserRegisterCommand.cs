namespace RMAProject.Domain.Commands
{
    public class UserRegisterCommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
