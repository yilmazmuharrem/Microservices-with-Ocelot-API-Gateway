namespace Company.API.Domain.Entities
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string  CompanyName { get; set; }
        public List<int> Sales { get; set; }
    }
}
