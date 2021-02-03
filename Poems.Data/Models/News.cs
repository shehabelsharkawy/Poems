using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class News
    {
        public int NewsId { get; set; }
        public int? DocumentId { get; set; }
        public int? OriginalWordCounts { get; set; }

        public virtual Document Document { get; set; }
    }
}
