using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class NewsUrlSource
    {
        public int SourceId { get; set; }
        public int DocumentId { get; set; }
        public int NewSourceId { get; set; }
        public int? PublisherId { get; set; }
        public string Title { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? AuthorId { get; set; }

        public virtual Document Document { get; set; }
        public virtual NewsPublisher Publisher { get; set; }
    }
}
