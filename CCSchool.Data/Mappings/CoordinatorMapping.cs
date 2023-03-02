using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class CoordinatorMapping : IEntityTypeConfiguration<Coordinator>
    {
        public void Configure(EntityTypeBuilder<Coordinator> builder)
        {
            builder.ToTable(nameof(Coordinator));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.User)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(30)
                    .IsRequired();

            builder.HasOne<Person>()
                    .WithOne()
                    .HasForeignKey<Person>(x => x.PersonId)
                    .IsRequired();

            builder.HasOne<Department>()
                    .WithMany(d => d.Coordinators)
                    .HasForeignKey(x => x.DepartmentId)
                    .IsRequired();
        }
    }
}
