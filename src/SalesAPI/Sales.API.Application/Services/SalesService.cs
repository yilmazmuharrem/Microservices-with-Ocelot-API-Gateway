using Sales.API.Domain.DTOs;
using Sales.API.Infrastructure.Interfaces;

namespace Sales.API.Application.Services
{
    public class SalesService : ISalesService
    {
        public SalesDto GetSalesById(int Id)
        {
            return new SalesDto
            {
                Id = new Random().Next(100),
                Amount = new Random().Next(10000),
                CompanyId = new Random().Next(10),
                SalesDate = DateTime.Now,
                SellerNameSurname = "Muharrem Y"
            };
        }

        public List<int> GetByCompanyId(int Id)
        {
            return new List<int> { Id, 20, 30 };

        }

    }
}
