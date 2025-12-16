using Company.API.Domain.BaseModel;
using Company.API.Domain.Entities;
using Company.API.Infrastructure.Interfaces;
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

        [HttpGet("{id}")]
        public GlobalResultDto<CompanyDto> Get(int id)
        {
            return _companyService.GetCompany(1);
        }

    }
}
