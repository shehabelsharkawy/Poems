using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentCategory
    {
        public int DocumentCategoryId { get; set; }
        public short CategoryId { get; set; }
        public int DocumentId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Document Document { get; set; }
    }
}
