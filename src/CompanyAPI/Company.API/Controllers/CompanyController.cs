using Company.API.Domain.BaseModel;
using Company.API.Domain.Entities;
using Company.API.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public ICompanyService _companyService { get; }
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("{Id}")]
        public GlobalResultDto<CompanyDto> Get(int Id)
        {
            return _companyService.GetCompany(1);
        }

    }
}
