using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class SourceFormat
    {
        public SourceFormat()
        {
            Books = new HashSet<Book>();
        }

        public int SourceFormatId { get; set; }
        public string SourceFormatName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
