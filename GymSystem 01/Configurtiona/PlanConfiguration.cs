using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configurtiona
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.CreateAt)
               .HasDefaultValueSql("GetDate()");
            builder.HasKey(x => x.Id);
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurationCheck", "DurationeDays Between 1 and 365");
            });
        }
    }
}
