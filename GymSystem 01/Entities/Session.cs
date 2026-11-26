namespace GymSystem.Entities
{
    public class Session : BaseEntities
    {
        public int Capacity { get; set; } = default!;
        public int Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; } //FK
        public Trainer Trainer { get; set; } = default!;

    }
}
