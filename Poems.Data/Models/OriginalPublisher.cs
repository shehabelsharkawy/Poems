using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class OriginalPublisher
    {
        public OriginalPublisher()
        {
            ComplimentaryCopyReceptors = new HashSet<ComplimentaryCopyReceptor>();
            OriginalPublisherInfos = new HashSet<OriginalPublisherInfo>();
        }

        public int OriginalPublisherId { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }

        public virtual ICollection<ComplimentaryCopyReceptor> ComplimentaryCopyReceptors { get; set; }
        public virtual ICollection<OriginalPublisherInfo> OriginalPublisherInfos { get; set; }
    }
}
