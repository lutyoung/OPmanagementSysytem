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
    public class VoteEntityTypeConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.ToTable("votes");

            builder.HasKey(v => v.Id);

            builder.HasIndex(v => new { v.ContestantId, v.PollId, v.VoterId })
                .IsUnique();

            builder.Property(v => v.TotalCount)
                .HasColumnType("bigint")
                .IsRequired();

            builder.Property(v => v.RowVersion)
                .IsRowVersion();
        }
    }
}
