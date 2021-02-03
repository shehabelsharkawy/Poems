using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PoemLanguage
    {
        public PoemLanguage()
        {
            Poems = new HashSet<Poem>();
        }

        public int LanguageId { get; set; }
        public string PoemLanguage1 { get; set; }

        public virtual ICollection<Poem> Poems { get; set; }
    }
}
