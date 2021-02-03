using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Channel
    {
        public Channel()
        {
            ChannelLocations = new HashSet<ChannelLocation>();
            ComplimentaryCopyReceptors = new HashSet<ComplimentaryCopyReceptor>();
        }

        public int ChannelId { get; set; }
        public string Name { get; set; }
        public int ChannelTypeId { get; set; }

        public virtual ChannelType ChannelType { get; set; }
        public virtual ICollection<ChannelLocation> ChannelLocations { get; set; }
        public virtual ICollection<ComplimentaryCopyReceptor> ComplimentaryCopyReceptors { get; set; }
    }
}
