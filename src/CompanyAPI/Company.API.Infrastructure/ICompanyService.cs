
using Company.API.Domain.BaseModel;
using Company.API.Domain.Entities;

namespace Company.API.Infrastructure
{
    public interface ICompanyService
    {
        public GlobalResultDto<CompanyDto> GetCompany(int companyId);
    }
}
