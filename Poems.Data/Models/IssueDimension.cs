using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class IssueDimension
    {
        public int DimensionId { get; set; }
        public int IssueId { get; set; }
        public bool IsUploaded { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
