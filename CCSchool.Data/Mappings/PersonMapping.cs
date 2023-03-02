using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable(nameof(Person));

            builder.HasKey(c => c.PersonId);

            builder.Property(c => c.Name)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(60)
                    .IsRequired();

            builder.Property(c => c.Email)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(60)
                    .IsRequired();

            builder.Property(c => c.Password)
                    .HasColumnType("NVARCHAR")
                    .IsRequired();

            builder.Property(c => c.Birth)
                    .HasColumnType("DATE")
                    .IsRequired();
        }
    }
}
