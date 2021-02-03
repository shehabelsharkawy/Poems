using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BooksTwc
    {
        public int? BookId { get; set; }
        public string TitleOriginal { get; set; }
        public string TitleArabic { get; set; }
        public int? TranslatedWordsCount { get; set; }
    }
}
