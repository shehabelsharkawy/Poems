using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class FreelancerRole
    {
        public FreelancerRole()
        {
            FreelancerUserRoles = new HashSet<FreelancerUserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<FreelancerUserRole> FreelancerUserRoles { get; set; }
    }
}
