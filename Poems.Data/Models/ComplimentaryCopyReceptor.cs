using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ComplimentaryCopyReceptor
    {
        public int ComplimentaryCopyId { get; set; }
        public int? AuthorId { get; set; }
        public int? OriginalPublisherId { get; set; }
        public int? ChannelId { get; set; }
        public int? UserId { get; set; }
        public int? FreelancerId { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual OriginalPublisher OriginalPublisher { get; set; }
    }
}
