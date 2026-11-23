using GymSystem.EnumGender;

namespace GymSystem.Entities
{
    public class GymUser : BaseEntities
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DOB { get; set; } = default!;
        public Gender Gender { get; set; } = default!;
    }
}
