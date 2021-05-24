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
    public class AdminEntityTypeConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("admins");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.FirstName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.LastName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.MiddleName)
                .HasColumnType("varchar(50)");

            builder.Property(a => a.Email)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasIndex(a => a.Email)
                .IsUnique();

            builder.Property(a => a.PhoneNumber)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.Gender)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(a => a.DateOfBirth)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(a => a.ProfilePic)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.AdminNumber)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.ResidentialAddress)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.City)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.State)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.RowVersion)
                .IsRowVersion();
        }

    }
}
