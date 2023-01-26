using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDBackend.Model
{
    public class SmokeOccasion
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public SmokeType TypeOfSmoke { get; set; }
        // If it is a vape or a ElfBar, it is not quantifiable
        public int? Quantity { get; set; }
        public string? Location { get; set; }
        public User User { get; set; }
    }
}
