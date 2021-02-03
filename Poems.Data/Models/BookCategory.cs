using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BookCategory
    {
        public int BookCategoryId { get; set; }
        public int BookId { get; set; }
        public short CategoryId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }
}
