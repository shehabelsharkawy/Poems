using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class AdType
    {
        public AdType()
        {
            KartoniatAds = new HashSet<KartoniatAd>();
        }

        public int AdTypeId { get; set; }
        public string AdTypeName { get; set; }

        public virtual ICollection<KartoniatAd> KartoniatAds { get; set; }
    }
}
