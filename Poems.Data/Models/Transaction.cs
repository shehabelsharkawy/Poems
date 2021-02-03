using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            TransationReceiptCoverages = new HashSet<TransationReceiptCoverage>();
        }

        public int TransactionId { get; set; }
        public int InvoiceId { get; set; }
        public int BookFormatId { get; set; }
        public DateTime Date { get; set; }
        public decimal? UnitRetailPrice { get; set; }
        public decimal? UnitNetPrice { get; set; }
        public int CopiesNumber { get; set; }
        public DateTime? InsertionDate { get; set; }
        public decimal? PayedPercentage { get; set; }

        public virtual BookFormat BookFormat { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<TransationReceiptCoverage> TransationReceiptCoverages { get; set; }
    }
}
