using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class OnlineBook
    {
        public int BookId { get; set; }
        public string BookCodeAr { get; set; }
        public string BookCodeEn { get; set; }
        public string BookTitleAr { get; set; }
        public string BookTitleEn { get; set; }
        public string BookIntroSummaryAr { get; set; }
        public string BookIntroSummaryEn { get; set; }
        public bool IsOnline { get; set; }
        public bool IsTranslated { get; set; }
        public int? KalimatBookId { get; set; }
        public bool IsArticle { get; set; }
    }
}
