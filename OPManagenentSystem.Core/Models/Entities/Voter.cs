using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Models.Entities
{
    public class Voter : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ProfilePic { get; set; }

        public string VoterNumber { get; set; }

        public string ResidentialAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public ICollection<Vote> Votes { get; set; } = new HashSet<Vote>();
    }
}
