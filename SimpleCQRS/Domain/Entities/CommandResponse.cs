namespace SimpleCQRS.Domain.Entities
{
    public class CommandResponse
    {
        public int Id { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}