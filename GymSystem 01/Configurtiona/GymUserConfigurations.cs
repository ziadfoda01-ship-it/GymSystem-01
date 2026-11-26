using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Configurtiona
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(e => e.Name)
                .HasColumnType("Varchar")
                .HasMaxLength(50);
            builder.Property(e => e.Email)
                .HasColumnType("Varchar")
                .HasMaxLength(100);
            builder.Property(e => e.Phone)
                .HasColumnType("varchar")
                .HasMaxLength(11);
            builder.ComplexProperty(a => a.Address);
            builder.HasIndex(p => p.Email).IsUnique();// Unique Email
            builder.HasIndex(p => p.Phone).IsUnique();//Unique Phone 
            builder.ToTable(T =>
                {
                    T.HasCheckConstraint("GymUse_EmailCheck ", "Email LIKE '_%@_%.com '");
                    T.HasCheckConstraint("GymUse_PhoneCheck ", "LEN ([Phone])=11 And ([Phone] LIKE '010%'Or [Phone] Like'011%' Or [Phone] Like '012%'Or [Phone] Like '015%' Or [Phone] Like'02%' )");

                });



        }
    }
}
