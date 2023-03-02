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
    internal class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(Student));

            builder.HasKey(x => x.RA);

            builder.Property(x => x.Nationality)
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(60)
                    .IsRequired();

            builder.Property(x => x.PicLink)
                    .HasColumnType("NVARCHAR");

            builder.Property(x => x.Cortesy)
                    .HasColumnType("BIT");

            builder.HasOne<Person>()
                    .WithOne()
                    .HasForeignKey<Person>(x => x.PersonId)
                    .IsRequired();
        }
    }
}
