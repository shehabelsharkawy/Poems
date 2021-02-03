using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class RandomDocId
    {
        public int Number { get; set; }
        public int? NumberOrder { get; set; }
        public bool? Used { get; set; }
    }
}
