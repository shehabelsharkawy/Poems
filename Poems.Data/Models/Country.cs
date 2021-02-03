using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            ChannelLocations = new HashSet<ChannelLocation>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ChannelLocation> ChannelLocations { get; set; }
    }
}
