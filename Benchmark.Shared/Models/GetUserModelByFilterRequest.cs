namespace Benchmark.Shared.Models
{
    public class GetUserModelByFilterRequest
    {
        public long? Id { get; set; }

        public Guid? ReferenceKey { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }
    }
}
