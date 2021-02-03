using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PoemStructure
    {
        public PoemStructure()
        {
            Poems = new HashSet<Poem>();
        }

        public int StructureId { get; set; }
        public string PoemStructure1 { get; set; }

        public virtual ICollection<Poem> Poems { get; set; }
    }
}
