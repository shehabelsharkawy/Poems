using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Document
    {
        public Document()
        {
            DocumentCategories = new HashSet<DocumentCategory>();
            DocumentContributors = new HashSet<DocumentContributor>();
            DocumentTasks = new HashSet<DocumentTask>();
            News = new HashSet<News>();
            NewsTags = new HashSet<NewsTag>();
            NewsUrlSources = new HashSet<NewsUrlSource>();
        }

        public int DocumentId { get; set; }
        public string TitleOriginal { get; set; }
        public string TitleArabic { get; set; }
        public int? LanguageId { get; set; }
        public string BlurbArabic { get; set; }
        public string BlurbEnglish { get; set; }
        public string TranslationType { get; set; }
        public string SubTitleOriginal { get; set; }
        public string SubTitleArabic { get; set; }
        public int DocumentType { get; set; }
        public string WorkSheetCode { get; set; }
        public int? WordsCount { get; set; }
        public int? FiguresCount { get; set; }
        public DateTime? PublicationDate { get; set; }
        public bool IsOld { get; set; }
        public string Notes { get; set; }
        public bool HasFigures { get; set; }
        public int? ItemNumber { get; set; }
        public int? PublisherId { get; set; }
        public int? PagesCount { get; set; }
        public bool IsDeleted { get; set; }
        public string ShortTitle { get; set; }
        public int? AuthoringLanguageId { get; set; }
        public int? SourceLanguageId { get; set; }
        public int? SourceFormatId { get; set; }
        public DateTime? HighPriorityDueDate { get; set; }

        public virtual ICollection<DocumentCategory> DocumentCategories { get; set; }
        public virtual ICollection<DocumentContributor> DocumentContributors { get; set; }
        public virtual ICollection<DocumentTask> DocumentTasks { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
        public virtual ICollection<NewsUrlSource> NewsUrlSources { get; set; }
    }
}
