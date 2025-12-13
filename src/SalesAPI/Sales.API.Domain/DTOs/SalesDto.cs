namespace Sales.API.Domain.DTOs
{
    public class SalesDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string SellerNameSurname { get; set; }
        public decimal Amount { get; set; }
        public DateTime? SalesDate { get; set; }

    }
}
