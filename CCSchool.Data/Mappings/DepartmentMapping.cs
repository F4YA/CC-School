using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class DepartmentMapping : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable(nameof(Department));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(30);

        }
    }
}
