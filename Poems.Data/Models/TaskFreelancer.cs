using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class TaskFreelancer
    {
        public int TaskFreelancerId { get; set; }
        public int TaskId { get; set; }
        public int FreelancerRoleId { get; set; }
        public double? FixedCost { get; set; }
        public double? PageCost { get; set; }
        public int? WordsCount { get; set; }

        public virtual FreelancerUserRole FreelancerRole { get; set; }
        public virtual Task Task { get; set; }
    }
}
