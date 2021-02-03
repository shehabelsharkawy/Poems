using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class AdScreen
    {
        public AdScreen()
        {
            KartoniatAds = new HashSet<KartoniatAd>();
        }

        public int AdScreenId { get; set; }
        public string AdScreenName { get; set; }

        public virtual ICollection<KartoniatAd> KartoniatAds { get; set; }
    }
}
