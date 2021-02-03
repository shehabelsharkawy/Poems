using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class NewsPublisher
    {
        public NewsPublisher()
        {
            NewsUrlSources = new HashSet<NewsUrlSource>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Url { get; set; }
        public int ItemNumber { get; set; }

        public virtual ICollection<NewsUrlSource> NewsUrlSources { get; set; }
    }
}
