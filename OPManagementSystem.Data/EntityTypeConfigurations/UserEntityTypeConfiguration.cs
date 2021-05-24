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
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User>builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserName)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.HasIndex(u => u.UserName)
                .IsUnique();

            builder.Property(u => u.PasswordHash)
                .HasColumnType("varchar(750)");

            builder.Property(u => u.HashSalt)
                .HasColumnType("varchar(700)");

            builder.Property(u => u.RowVersion)
                .IsRowVersion();

            builder.HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
