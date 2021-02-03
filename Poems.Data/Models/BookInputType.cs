using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BookInputType
    {
        public int BookInputTypeId { get; set; }
        public int BookId { get; set; }
        public int InputTypeId { get; set; }
        public int? WordsCount { get; set; }
        public short? PagesCount { get; set; }
        public double? Cost { get; set; }
        public double? CostQc { get; set; }

        public virtual Book Book { get; set; }
        public virtual InputType InputType { get; set; }
    }
}
