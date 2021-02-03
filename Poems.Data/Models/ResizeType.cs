using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ResizeType
    {
        public int ResizeId { get; set; }
        public int ResizeType1 { get; set; }
        public string ResizeDimension { get; set; }
        public bool? IsActive { get; set; }
    }
}
