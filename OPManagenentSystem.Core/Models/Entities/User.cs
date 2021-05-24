using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Models.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string HashSalt { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
