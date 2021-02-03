using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BookContributor
    {
        public int BookContributorId { get; set; }
        public int BookId { get; set; }
        public int ContributorRoleId { get; set; }

        public virtual Book Book { get; set; }
        public virtual ContributorContributorRole ContributorRole { get; set; }
    }
}
