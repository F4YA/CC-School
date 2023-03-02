using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class PhoneMapping : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable(nameof(Phone));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Number)
                    .HasColumnType("BIGINT")
                    .IsRequired();

            builder.HasOne<Person>()
                    .WithMany(p => p.Phones)
                    .HasForeignKey(x => x.PersonId)
                    .IsRequired();
        }
    }
}
