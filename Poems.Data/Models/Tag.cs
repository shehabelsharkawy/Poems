using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Tag
    {
        public Tag()
        {
            DocumentTags = new HashSet<DocumentTag>();
            NewsTags = new HashSet<NewsTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public int ItemNumber { get; set; }

        public virtual ICollection<DocumentTag> DocumentTags { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
    }
}
