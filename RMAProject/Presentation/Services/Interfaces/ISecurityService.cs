namespace RMAProject.Presentation.Services.Interfaces
{
    public interface ISecurityService
    {
        Task<Dictionary<string, string>> GenerateSaltAndHash(string password);
    }
}
