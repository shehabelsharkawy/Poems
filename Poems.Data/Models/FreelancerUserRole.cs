using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class FreelancerUserRole
    {
        public FreelancerUserRole()
        {
            DocumentTaskFreelancers = new HashSet<DocumentTaskFreelancer>();
            TaskFreelancers = new HashSet<TaskFreelancer>();
        }

        public int FreelancerRoleId { get; set; }
        public int FreelancerId { get; set; }
        public int RoleId { get; set; }

        public virtual FreelancerUser Freelancer { get; set; }
        public virtual FreelancerRole Role { get; set; }
        public virtual ICollection<DocumentTaskFreelancer> DocumentTaskFreelancers { get; set; }
        public virtual ICollection<TaskFreelancer> TaskFreelancers { get; set; }
    }
}
