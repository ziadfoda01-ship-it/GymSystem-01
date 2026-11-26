using System.ComponentModel.DataAnnotations.Schema;

namespace GymSystem.Entities
{
    public class MemberShip : BaseEntities
    {

        public int memberId { get; set; } = default!;
        public Member member { get; set; } = default!;
        public int PlanId { get; set; } = default!;
        public Plan plan { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";
    }
}
