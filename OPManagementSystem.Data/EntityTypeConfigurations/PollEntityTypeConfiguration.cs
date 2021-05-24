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
    public class PollEntityTypeConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {

            builder.ToTable("polls");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(p => p.RowVersion)
                .IsRowVersion();

            builder.HasMany(cp => cp.ContestantPolls)
               .WithOne(cp => cp.Poll)
               .HasForeignKey(cp => cp.PollId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(v => v.Votes)
               .WithOne(v => v.Poll)
               .HasForeignKey(v => v.PollId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
