﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Models.Entities
{
    public class Role :BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
