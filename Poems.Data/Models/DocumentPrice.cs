using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentPrice
    {
        public int DocuemntPriceId { get; set; }
        public int DocumentId { get; set; }
        public decimal Price { get; set; }
        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
