using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class FreelancerLanguage
    {
        public int FreelancerLanguageId { get; set; }
        public int FreelancerId { get; set; }
        public int LanguageId { get; set; }

        public virtual FreelancerUser Freelancer { get; set; }
        public virtual Language Language { get; set; }
    }
}
