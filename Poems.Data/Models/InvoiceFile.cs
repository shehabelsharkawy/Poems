using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class InvoiceFile
    {
        public int InvoiceFileId { get; set; }
        public int InvoiceId { get; set; }
        public string Path { get; set; }
        public DateTime UploadDate { get; set; }
        public string FileName { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
