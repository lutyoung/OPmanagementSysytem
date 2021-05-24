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
    public class UserRoleEntityTypeConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("userRoles");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => new { u.UserId, u.RoleId })
                .IsUnique();

            builder.Property(u => u.RowVersion)
                .IsRowVersion();
        }
    }
}
