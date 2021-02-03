using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentPriceHistory
    {
        public int DocumentPriceHistoryId { get; set; }
        public int DocumentId { get; set; }
        public decimal? Price { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime Date { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
