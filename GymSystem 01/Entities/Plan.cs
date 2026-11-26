namespace GymSystem.Entities
{
    public class Plan : BaseEntities
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int DurationeDays { get; set; } = default!;
        public bool IsActive { get; set; } = default!;
        public ICollection<MemberShip> memberShips { get; set; } = default!;
    }
}
