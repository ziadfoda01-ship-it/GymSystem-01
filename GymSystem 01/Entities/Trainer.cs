using GymSystem.EnumGender;

namespace GymSystem.Entities
{
    public class Trainer : GymUser
    {
        public Speciality Speciality { get; set; }
        public ICollection<Session> sessions { get; set; } = default!;
    }
}
