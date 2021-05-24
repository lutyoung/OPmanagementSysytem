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
    public class ContestantPollEntityTypeConfiguration : IEntityTypeConfiguration<ContestantPoll>
    {
        public void Configure(EntityTypeBuilder<ContestantPoll> builder)
        {
            builder.ToTable("contestantpolls");

            builder.HasKey(cp => cp.Id);

            builder.HasIndex(cp => new { cp.ContestantId, cp.PollId })
                .IsUnique();

            builder.Property(cp => cp.RowVersion)
                .IsRowVersion();

        }
    }
}
