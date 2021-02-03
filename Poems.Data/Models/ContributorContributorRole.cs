using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ContributorContributorRole
    {
        public ContributorContributorRole()
        {
            BookContributors = new HashSet<BookContributor>();
            DocumentContributors = new HashSet<DocumentContributor>();
            PoemContributors = new HashSet<PoemContributor>();
        }

        public int ContributorRoleId { get; set; }
        public int ContributorId { get; set; }
        public short RoleId { get; set; }

        public virtual Contributor Contributor { get; set; }
        public virtual ContributorRole Role { get; set; }
        public virtual ICollection<BookContributor> BookContributors { get; set; }
        public virtual ICollection<DocumentContributor> DocumentContributors { get; set; }
        public virtual ICollection<PoemContributor> PoemContributors { get; set; }
    }
}
