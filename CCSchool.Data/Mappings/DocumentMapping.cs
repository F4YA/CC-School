using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class DocumentMapping : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable(nameof(Document));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Value)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(20);

            builder.HasOne<Person>()
                    .WithMany(p => p.Documents)
                    .HasForeignKey(e => e.PersonId)
                    .IsRequired();

            builder.HasOne<DocumentType>()
                   .WithMany(dt => dt.Documents)
                   .HasForeignKey(e => e.DocumentTypeId)
                   .IsRequired();
        }
    }
}
