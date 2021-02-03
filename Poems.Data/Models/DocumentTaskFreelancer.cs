using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentTaskFreelancer
    {
        public int DocumentTaskFreelancerId { get; set; }
        public int DocumentTaskId { get; set; }
        public int FreelancerRoleId { get; set; }
        public double? PageCost { get; set; }
        public int? WordsCount { get; set; }
        public double? FixedCost { get; set; }

        public virtual DocumentTask DocumentTask { get; set; }
        public virtual FreelancerUserRole FreelancerRole { get; set; }
    }
}
