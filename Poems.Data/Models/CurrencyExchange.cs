using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class CurrencyExchange
    {
        public int CurrencyExchangeId { get; set; }
        public DateTime? CurrencyExchangeDate { get; set; }
        public decimal? CurrencyExchangeRate { get; set; }
        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
