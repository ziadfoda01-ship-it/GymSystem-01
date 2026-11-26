using Microsoft.EntityFrameworkCore;

namespace GymSystem.Entities
{
    [Owned]
    public class Address
    {
        public string City { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string BuildingNumber { get; set; } = default!;
    }
}
