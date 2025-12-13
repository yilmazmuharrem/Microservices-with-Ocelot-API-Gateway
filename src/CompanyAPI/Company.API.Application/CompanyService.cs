using Company.API.Domain.BaseModel;
using Company.API.Domain.Entities;
using Company.API.Infrastructure;

namespace Company.API.Application
{
    public class CompanyService : ICompanyService
    {
        public GlobalResultDto<CompanyDto> GetCompany(int companyId)
        {
            return new GlobalResultDto<CompanyDto>()
            {
                IsSucced = true,
                Message = "İşlem başarılı",
                Result = new CompanyDto
                {
                    CompanyName = "Organizer Ypas Test Firması",
                    Id = new Random().Next(1,14),
                    Sales = new List<int> { 52, 63, 52 }
                }
            };
        }
    }
}
