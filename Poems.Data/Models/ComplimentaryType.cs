using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ComplimentaryType
    {
        public ComplimentaryType()
        {
            ComplimentaryCopies = new HashSet<ComplimentaryCopy>();
        }

        public int ComplimentaryTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<ComplimentaryCopy> ComplimentaryCopies { get; set; }
    }
}
