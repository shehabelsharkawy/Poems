using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ReceiptFile
    {
        public string FileName { get; set; }
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public string Path { get; set; }
        public DateTime UploadDate { get; set; }

        public virtual PaymentReceipt Receipt { get; set; }
    }
}
