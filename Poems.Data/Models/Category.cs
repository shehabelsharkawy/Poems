using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            BookCategories = new HashSet<BookCategory>();
            DocumentCategories = new HashSet<DocumentCategory>();
        }

        public short CategoryId { get; set; }
        public string TitleEnglish { get; set; }
        public string TitleArabic { get; set; }
        public int? ItemNumberOld { get; set; }
        public int ItemNumber { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }
        public virtual ICollection<DocumentCategory> DocumentCategories { get; set; }
    }
}
