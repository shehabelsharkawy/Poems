using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class FeaturedPanel
    {
        public int FeaturedPanelId { get; set; }
        public int DocumentId { get; set; }
        public int FeaturedPanelNum { get; set; }
    }
}
