using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ContributorProbability
    {
        public ContributorProbability()
        {
            ContributorProbabilityDetails = new HashSet<ContributorProbabilityDetail>();
        }

        public int ContributorProbabilityId { get; set; }
        public int TypeId { get; set; }
        public int? NotToBeAlone { get; set; }

        public virtual ICollection<ContributorProbabilityDetail> ContributorProbabilityDetails { get; set; }
    }
}
