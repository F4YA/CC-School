using CCSchool.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Data.Mappings
{
    internal class InstructorMapping : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable(nameof(Instructor));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.User)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(30)
                    .IsRequired();

            builder.Property(x => x.Active)
                    .HasColumnType("BIT");

            builder.HasMany(x => x.Subjects)
                    .WithMany(s => s.Instructors);
        }
    }
}
