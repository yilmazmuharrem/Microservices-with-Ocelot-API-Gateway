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

        [HttpGet("{id}")]

        public SalesDto Get(int id)
        {
            return _salesService.GetSalesById(id);
        }


        [HttpGet("company/{id}")]

        public SalesDto GetByCompanyId(int id)
        {
            return _salesService.GetSalesById(id);
        }


    }
}
