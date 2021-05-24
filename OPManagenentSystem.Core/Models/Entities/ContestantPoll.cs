using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Models.Entities
{
    public class ContestantPoll : BaseEntity
    {
        public Guid ContestantId { get; set; }

        public Contestant Contestant { get; set; }

        public Guid PollId { get; set; }

        public Poll Poll { get; set; }
    }
}
