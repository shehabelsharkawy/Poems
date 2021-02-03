using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Language
    {
        public Language()
        {
            BookAuthoringLanguages = new HashSet<Book>();
            BookLanguages = new HashSet<Book>();
            BookSourceLanguages = new HashSet<Book>();
            FreelancerLanguages = new HashSet<FreelancerLanguage>();
        }

        public int LanguageId { get; set; }
        public string TitleEnglish { get; set; }
        public string TitleArabic { get; set; }

        public virtual ICollection<Book> BookAuthoringLanguages { get; set; }
        public virtual ICollection<Book> BookLanguages { get; set; }
        public virtual ICollection<Book> BookSourceLanguages { get; set; }
        public virtual ICollection<FreelancerLanguage> FreelancerLanguages { get; set; }
    }
}
