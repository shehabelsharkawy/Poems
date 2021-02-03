using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ComplimentaryCopy
    {
        public int ComplimentaryCopyId { get; set; }
        public string Name { get; set; }
        public int ComplimentaryTypeId { get; set; }
        public int BookFormatId { get; set; }
        public int CopiesNumber { get; set; }
        public DateTime InsertionDate { get; set; }
        public DateTime HandOutDate { get; set; }

        public virtual BookFormat BookFormat { get; set; }
        public virtual ComplimentaryType ComplimentaryType { get; set; }
    }
}
