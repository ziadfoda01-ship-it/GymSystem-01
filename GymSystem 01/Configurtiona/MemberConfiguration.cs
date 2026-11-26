using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configurtiona
{
    public class MemberConfiguration : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(p => p.CreateAt)
                .HasColumnName("JoinDate")
                .HasDefaultValueSql("GetDate()");


            base.Configure(builder); // Apply Configuration Of GymUse [parent]
        }
    }
}
