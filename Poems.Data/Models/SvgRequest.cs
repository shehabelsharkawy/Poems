using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class SvgRequest
    {
        public int SvgRequestId { get; set; }
        public int ItemNumber { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string ErrorDetails { get; set; }
        public DateTime InsertionDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public bool TestSvg { get; set; }
    }
}
