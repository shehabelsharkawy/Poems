using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Format
    {
        public Format()
        {
            BookFormats = new HashSet<BookFormat>();
        }

        public int FormatId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookFormat> BookFormats { get; set; }
    }
}
