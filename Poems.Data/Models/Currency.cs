using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Currency
    {
        public Currency()
        {
            CurrencyExchanges = new HashSet<CurrencyExchange>();
            DocumentPriceHistories = new HashSet<DocumentPriceHistory>();
            DocumentPrices = new HashSet<DocumentPrice>();
            Invoices = new HashSet<Invoice>();
            PaymentReceipts = new HashSet<PaymentReceipt>();
        }

        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Sign { get; set; }
        public string Isocode { get; set; }

        public virtual ICollection<CurrencyExchange> CurrencyExchanges { get; set; }
        public virtual ICollection<DocumentPriceHistory> DocumentPriceHistories { get; set; }
        public virtual ICollection<DocumentPrice> DocumentPrices { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
    }
}
