using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class RofoufAuthor
    {
        public int RofoufAuthorId { get; set; }
        public int RofoufFileId { get; set; }
        public string AuthorName { get; set; }

        public virtual RofoufStatus RofoufFile { get; set; }
    }
}
