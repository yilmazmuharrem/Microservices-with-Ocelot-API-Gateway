using Microsoft.AspNetCore.Mvc;
using Sales.API.Domain.DTOs;
using Sales.API.Infrastructure.Interfaces;

namespace Sales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        public ISalesService _salesService { get; }
        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }

        [HttpGet("{Id}")]

        public SalesDto Get(int Id)
        {
            return _salesService.GetSalesById(Id);
        }


        [HttpGet("company/{companyId}")]

        public SalesDto GetByCompanyId(int companyId)
        {
            return _salesService.GetSalesById(companyId);
        }


    }
}
