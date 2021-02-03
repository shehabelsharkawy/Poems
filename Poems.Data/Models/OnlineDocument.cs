using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class OnlineDocument
    {
        public int DocumentId { get; set; }
        public string DocumentCodeAr { get; set; }
        public string DocumentCodeEn { get; set; }
        public string DocumentTitleAr { get; set; }
        public string DocumentTitleEn { get; set; }
        public string DocumentIntroSummaryAr { get; set; }
        public string DocumentIntroSummaryEn { get; set; }
        public bool IsOnline { get; set; }
        public bool IsTranslated { get; set; }
        public int? KalimatDocumentId { get; set; }
        public bool IsArticle { get; set; }
        public int DocumentType { get; set; }
    }
}
