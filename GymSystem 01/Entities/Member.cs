namespace GymSystem.Entities
{
    public class Member : GymUser
    {
        public string Photo { get; set; } = default!;
        public ICollection<MemberShip> memberShips { get; set; } = default!;
    }
}
