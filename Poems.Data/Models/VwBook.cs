using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class VwBook
    {
        public int BookId { get; set; }
        public string TitleOriginal { get; set; }
        public string TitleArabic { get; set; }
        public int? LanguageId { get; set; }
        public string BlurbArabic { get; set; }
        public string BlurbEnglish { get; set; }
        public short? PagesCount { get; set; }
        public int? WordsCount { get; set; }
        public short? FiguresCount { get; set; }
        public string OriginalPublicationDate { get; set; }
        public DateTime? DueDatePublication { get; set; }
        public string TypeOfInput { get; set; }
        public bool IsTranslated { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsDigitalFreeCopy { get; set; }
        public double? Width { get; set; }
        public double? Hight { get; set; }
        public bool? IsCoverPainted { get; set; }
        public string Notes { get; set; }
        public string TranslationType { get; set; }
        public bool HasFigures { get; set; }
        public string BackCover { get; set; }
        public bool? IsOld { get; set; }
        public string SubTitleOriginal { get; set; }
        public string SubTitleArabic { get; set; }
        public string WorkSheetCode { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int DocumentType { get; set; }
        public string ArticlePublicationDate { get; set; }
        public bool HasCopyRightCover { get; set; }
        public string IssueNumber { get; set; }
        public string VolumeNumber { get; set; }
        public string DocPageNums { get; set; }
        public int? PublisherId { get; set; }
        public bool? IsCollected { get; set; }
        public bool? IsSelection { get; set; }
        public int? ContentTypeId { get; set; }
        public int? IssueId { get; set; }
        public int? ItemNumberOld { get; set; }
        public int? ItemNumber { get; set; }
        public int? AuthoringLanguageId { get; set; }
        public int? SourceLanguageId { get; set; }
        public int? SourceFormatId { get; set; }
        public bool? IsGraphicalNovels { get; set; }
        public int? SeriesId { get; set; }
        public bool IsTashkeel { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHighPriority { get; set; }
        public bool IsDeleted { get; set; }
        public string ShortTitle { get; set; }
        public string OriginalIsbn { get; set; }
        public string PrintedIsbn { get; set; }
        public string PrintedRegistrationNumber { get; set; }
        public string DigitalIsbn { get; set; }
        public string DigitalRegistrationNumber { get; set; }
        public int? MarktingPlanId { get; set; }
        public int? MarktingDocumentId { get; set; }
        public bool? HasMarktingPlan { get; set; }
        public DateTime? MarktingStartDate { get; set; }
        public bool? PlanFinished { get; set; }
        public DateTime? FinishedDate { get; set; }
        public int? RoyaltiesType { get; set; }
        public DateTime? HighPriorityDueDate { get; set; }
        public int? EpubCssversion { get; set; }
        public bool IsForSale { get; set; }
        public string OriginalPublishedDate { get; set; }
        public string FirstTranslationPublishedDate { get; set; }
    }
}
