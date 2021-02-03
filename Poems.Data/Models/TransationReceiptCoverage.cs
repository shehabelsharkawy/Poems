using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class TransationReceiptCoverage
    {
        public int TransactionId { get; set; }
        public int RecieptId { get; set; }
        public decimal? CoverageAmount { get; set; }
        public decimal? Ratio { get; set; }
        public int StaffId { get; set; }
        public DateTime? InsertionDate { get; set; }

        public virtual PaymentReceipt Reciept { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
