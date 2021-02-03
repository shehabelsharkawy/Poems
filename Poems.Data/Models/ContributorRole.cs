using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ContributorRole
    {
        public ContributorRole()
        {
            ContributorContributorRoles = new HashSet<ContributorContributorRole>();
            ContributorProbabilityDetails = new HashSet<ContributorProbabilityDetail>();
        }

        public short RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<ContributorContributorRole> ContributorContributorRoles { get; set; }
        public virtual ICollection<ContributorProbabilityDetail> ContributorProbabilityDetails { get; set; }
    }
}
