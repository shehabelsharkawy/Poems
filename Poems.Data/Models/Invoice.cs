using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceFiles = new HashSet<InvoiceFile>();
            Transactions = new HashSet<Transaction>();
        }

        public int InvoiceId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int ChannelLocationId { get; set; }
        public int CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public int StaffId { get; set; }
        public DateTime? InsertionDate { get; set; }
        public int PaymentStateId { get; set; }

        public virtual ChannelLocation ChannelLocation { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual PaymentState PaymentState { get; set; }
        public virtual User Staff { get; set; }
        public virtual ICollection<InvoiceFile> InvoiceFiles { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
