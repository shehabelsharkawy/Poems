using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class TranslationDetail
    {
        public int TranslationDetailsId { get; set; }
        public int TaskId { get; set; }
        public int TranslatedWordsCount { get; set; }
        public int C1 { get; set; }
        public int C2 { get; set; }
        public int C3 { get; set; }
        public int C4 { get; set; }
        public int C5 { get; set; }

        public virtual Task Task { get; set; }
    }
}
