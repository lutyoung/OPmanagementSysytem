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
    public class VoterEntityTypeConfiguration : IEntityTypeConfiguration<Voter>
    {
        public void Configure(EntityTypeBuilder<Voter> builder)
        {
            builder.ToTable("voters");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.FirstName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.LastName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.MiddleName)
                .HasColumnType("varchar(50)");

            builder.Property(v => v.Email)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasIndex(v => v.Email)
                .IsUnique();

            builder.Property(v => v.PhoneNumber)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.Gender)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(v => v.DateOfBirth)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(v => v.ProfilePic)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.VoterNumber)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.ResidentialAddress)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.City)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.State)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(v => v.RowVersion)
                .IsRowVersion();

            builder.HasMany(v => v.Votes)
               .WithOne(v => v.Voter)
               .HasForeignKey(v => v.VoterId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
