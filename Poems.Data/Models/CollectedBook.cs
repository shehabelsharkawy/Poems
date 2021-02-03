using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class CollectedBook
    {
        public int CollectionId { get; set; }
        public int FinalBookId { get; set; }
        public int CollectedFromId { get; set; }
    }
}
