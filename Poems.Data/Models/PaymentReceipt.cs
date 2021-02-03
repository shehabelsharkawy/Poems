using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PaymentReceipt
    {
        public PaymentReceipt()
        {
            ReceiptFiles = new HashSet<ReceiptFile>();
            TransationReceiptCoverages = new HashSet<TransationReceiptCoverage>();
        }

        public int Id { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ExchangeRate { get; set; }
        public int CurrencyId { get; set; }
        public int PaymentTypeId { get; set; }
        public int ChannelLocationId { get; set; }
        public int StaffId { get; set; }
        public DateTime? InsertionDate { get; set; }

        public virtual ChannelLocation ChannelLocation { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual User Staff { get; set; }
        public virtual ICollection<ReceiptFile> ReceiptFiles { get; set; }
        public virtual ICollection<TransationReceiptCoverage> TransationReceiptCoverages { get; set; }
    }
}
