using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentContributor
    {
        public int DocumentContributorId { get; set; }
        public int DocumentId { get; set; }
        public int? ContributorRoleId { get; set; }

        public virtual ContributorContributorRole ContributorRole { get; set; }
        public virtual Document Document { get; set; }
    }
}
