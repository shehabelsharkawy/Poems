using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class OriginalPublisherInfo
    {
        public int OriginalPublisherInfoId { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public int OriginalPublisherId { get; set; }

        public virtual OriginalPublisher OriginalPublisher { get; set; }
    }
}
