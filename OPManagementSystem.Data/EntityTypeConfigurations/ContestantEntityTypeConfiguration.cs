using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OPManagement.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagementSystem.Data.EntityTypeConfigurations
{
    public class ContestantEntityTypeConfiguration : IEntityTypeConfiguration<Contestant>
    {
        public void Configure(EntityTypeBuilder<Contestant> builder)
        {
            builder.ToTable("contestants");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(c => c.LastName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.MiddleName)
               .HasColumnType("varchar(50)");

            builder.Property(c => c.Email)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasIndex(c => c.Email)
                .IsUnique();

            builder.Property(c => c.PhoneNumber)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(c => c.Gender)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(c => c.DateOfBirth)
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(c => c.ProfilePic)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.ContestantNumber)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(c => c.Information)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder.Property(c => c.RowVersion)
                .IsRowVersion();

            builder.HasMany(cp => cp.ContestantPolls)
               .WithOne(cp => cp.Contestant)
               .HasForeignKey(cp => cp.ContestantId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(v => v.Votes)
               .WithOne(v => v.Contestant)
               .HasForeignKey(v => v.ContestantId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
