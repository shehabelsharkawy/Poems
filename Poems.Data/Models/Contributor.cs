using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Contributor
    {
        public Contributor()
        {
            ContributorContributorRoles = new HashSet<ContributorContributorRole>();
        }

        public int ContributorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ArabicName { get; set; }
        public string BioOriginal { get; set; }
        public string BioArabic { get; set; }
        public string Gender { get; set; }
        public bool? IsVisible { get; set; }
        public int? ItemNumberOld { get; set; }
        public int? ItemNumber { get; set; }
        public int ContributorType { get; set; }
        public bool? HasPhoto { get; set; }
        public DateTime? SentNotificationMail { get; set; }

        public virtual ICollection<ContributorContributorRole> ContributorContributorRoles { get; set; }
    }
}
