using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CCSchool.Data.Mappings
{
    internal class DocumentTypeMapping : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable(nameof(DocumentType));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Type)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(60)
                    .IsRequired();
        }
    }
}
