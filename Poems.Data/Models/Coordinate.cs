using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Coordinate
    {
        public int CoordinateId { get; set; }
        public int ItemNumber { get; set; }
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int X3 { get; set; }
        public int X4 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public int Y3 { get; set; }
        public int Y4 { get; set; }
    }
}
