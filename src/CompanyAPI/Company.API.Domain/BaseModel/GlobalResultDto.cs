namespace Company.API.Domain.BaseModel
{
    public class GlobalResultDto<T> where T : class
    {
        public bool IsSucced { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
