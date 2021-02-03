using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Ftpqueue
    {
        public int FtpqueueId { get; set; }
        public int? ItemNumber { get; set; }
        public string Doctype { get; set; }
    }
}
