using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Dimension
    {
        public int DimensionId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string DimensionType { get; set; }
        public string S3path { get; set; }
        public bool IsTemp { get; set; }
        public string Device { get; set; }
        public string Usage { get; set; }
    }
}
