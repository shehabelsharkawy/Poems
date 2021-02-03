using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Poem
    {
        public Poem()
        {
            PoemContributors = new HashSet<PoemContributor>();
            PoemTasks = new HashSet<PoemTask>();
        }

        public int PoemId { get; set; }
        public int? ItemNumber { get; set; }
        public string PoemTitle { get; set; }
        public int PoemLanguageId { get; set; }
        public string PoemCause { get; set; }
        public string PoemPurpose { get; set; }
        public int PoemEraId { get; set; }
        public int PoemTypeId { get; set; }
        public int PoemStructureId { get; set; }
        public DateTime? PublishingDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string AboutPoetTitleA { get; set; }
        public bool? HasAudio { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsRelatedToBook { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual PoemEra PoemEra { get; set; }
        public virtual PoemLanguage PoemLanguage { get; set; }
        public virtual PoemStructure PoemStructure { get; set; }
        public virtual PoemType PoemType { get; set; }
        public virtual ICollection<PoemContributor> PoemContributors { get; set; }
        public virtual ICollection<PoemTask> PoemTasks { get; set; }
    }
}
