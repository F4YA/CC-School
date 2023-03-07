using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class CourseMapping : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable(nameof(Course));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(60)
                    .IsRequired();

            builder.Property(x => x.Description)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(500)
                    .IsRequired();

            builder.Property(x => x.Active)
                    .HasColumnType("BYTE");

            builder.Property(x => x.Type)
                    .HasConversion<int>()
                    .IsRequired();
        }
    }
}
