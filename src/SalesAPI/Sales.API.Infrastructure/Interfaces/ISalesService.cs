using Sales.API.Domain.DTOs;

namespace Sales.API.Infrastructure.Interfaces
{
    public interface ISalesService
    {
        public SalesDto GetSalesById(int Id);

        List<int> GetByCompanyId(int companyId);
    }
}
