using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PoemEra
    {
        public PoemEra()
        {
            Poems = new HashSet<Poem>();
        }

        public int EraId { get; set; }
        public string PoemEra1 { get; set; }

        public virtual ICollection<Poem> Poems { get; set; }
    }
}
