using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ImageResize
    {
        public int Id { get; set; }
        public string SourceType { get; set; }
        public string Destination { get; set; }
        public int Width { get; set; }
    }
}
