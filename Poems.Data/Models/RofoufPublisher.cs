using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class RofoufPublisher
    {
        public int RofoufPublisherId { get; set; }
        public int RofoufFileId { get; set; }
        public string PublisherName { get; set; }

        public virtual RofoufStatus RofoufFile { get; set; }
    }
}
