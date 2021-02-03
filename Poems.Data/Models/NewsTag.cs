using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class NewsTag
    {
        public int NewsTagId { get; set; }
        public int DocumentId { get; set; }
        public int TagId { get; set; }

        public virtual Document Document { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
