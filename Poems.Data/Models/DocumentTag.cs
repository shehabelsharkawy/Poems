using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentTag
    {
        public int DocumentTagId { get; set; }
        public int DocumentId { get; set; }
        public int TagId { get; set; }

        public virtual Book Document { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
