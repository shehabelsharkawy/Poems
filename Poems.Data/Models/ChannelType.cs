using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ChannelType
    {
        public ChannelType()
        {
            Channels = new HashSet<Channel>();
        }

        public int ChannelTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Channel> Channels { get; set; }
    }
}
