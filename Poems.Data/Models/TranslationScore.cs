using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class TranslationScore
    {
        public int ScoreId { get; set; }
        public DateTime? Date { get; set; }
        public double CommonFactor { get; set; }
        public double C1 { get; set; }
        public double C2 { get; set; }
        public double C3 { get; set; }
        public double C4 { get; set; }
        public double C5 { get; set; }
    }
}
