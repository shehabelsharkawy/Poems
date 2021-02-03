using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class FreelancerUser
    {
        public FreelancerUser()
        {
            FreelancerLanguages = new HashSet<FreelancerLanguage>();
            FreelancerUserRoles = new HashSet<FreelancerUserRole>();
        }

        public int FreelancerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int FreelancerRole { get; set; }
        public string Gender { get; set; }
        public int? ItemNumber { get; set; }
        public bool? Active { get; set; }
        public string Comments { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<FreelancerLanguage> FreelancerLanguages { get; set; }
        public virtual ICollection<FreelancerUserRole> FreelancerUserRoles { get; set; }
    }
}
