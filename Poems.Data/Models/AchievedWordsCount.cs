using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class AchievedWordsCount
    {
        public int AchievedWordsCountId { get; set; }
        public int TaskId { get; set; }
        public int WordsCount { get; set; }
        public DateTime AchievedDate { get; set; }
        public double RateFactor { get; set; }
        public byte WordType { get; set; }

        public virtual Task Task { get; set; }
    }
}
