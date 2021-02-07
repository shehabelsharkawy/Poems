using System;
using System.Collections.Generic;
using System.Text;

namespace Poems.Shared.ViewModels
{
    public class PoemViewModel
    {
        public int PoemId { get; set; }
        public int? ItemNumber { get; set; }
        public string PoemTitle { get; set; }
        public string Poet { get; set; }
        public int PoemLanguageId { get; set; }
        public string PoemCause { get; set; }
        public string PoemPurpose { get; set; }
        public int PoemEraId { get; set; }
        public int PoemTypeId { get; set; }
        public int PoemStructureId { get; set; }
        public DateTime? PublishingDate { get; set; }
        public string AboutPoetTitleA { get; set; }
        public bool? HasAudio { get; set; }
        public bool IsActive { get; set; }
        public virtual string PoemEra { get; set; }
        public virtual string PoemLanguage { get; set; }
        public virtual string PoemStructure { get; set; }
        public virtual string PoemType { get; set; }

    }
}
