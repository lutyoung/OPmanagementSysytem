using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Models.Entities
{
    public class Poll : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<ContestantPoll> ContestantPolls { get; set; } = new List<ContestantPoll>();

        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}
