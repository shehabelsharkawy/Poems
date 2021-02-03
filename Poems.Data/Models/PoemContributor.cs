using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PoemContributor
    {
        public int PoemContributorId { get; set; }
        public int PoemId { get; set; }
        public int ContributorRoleId { get; set; }

        public virtual ContributorContributorRole ContributorRole { get; set; }
        public virtual Poem Poem { get; set; }
    }
}
