using Microsoft.AspNetCore.Mvc;
using RMAProject.Domain.Commands;
using RMAProject.Presentation.Services.Interfaces;

namespace RMAProject.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/companies")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> RegisterCompany(CompanyRegisterCommand command)
        {
            await _companyService.RegisterCompany(command);
            return Ok("Empresa criada com sucesso");
        }
    }
}
