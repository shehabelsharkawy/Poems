using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ContributorProbabilityDetail
    {
        public int ContributorProbabilityDetailId { get; set; }
        public int ContributorProbabilityId { get; set; }
        public short? Detail { get; set; }

        public virtual ContributorProbability ContributorProbability { get; set; }
        public virtual ContributorRole DetailNavigation { get; set; }
    }
}
