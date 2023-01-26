using MSDBackend.Model;

namespace MSDBackend.Application.Model
{
    public class SmokeOccasionDto
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public SmokeType TypeOfSmoke { get; set; }
        // If it is a vape or a ElfBar, it is not quantifiable
        public int? Quantity { get; set; }
        public string? Location { get; set; }
    }
}
