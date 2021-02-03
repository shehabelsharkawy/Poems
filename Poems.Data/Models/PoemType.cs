using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PoemType
    {
        public PoemType()
        {
            Poems = new HashSet<Poem>();
        }

        public int TypeId { get; set; }
        public string PoemType1 { get; set; }

        public virtual ICollection<Poem> Poems { get; set; }
    }
}
