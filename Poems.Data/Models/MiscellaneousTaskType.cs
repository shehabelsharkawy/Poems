using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class MiscellaneousTaskType
    {
        public MiscellaneousTaskType()
        {
            MiscellaneousTasks = new HashSet<MiscellaneousTask>();
        }

        public int MiscellaneousTaskTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? MinHours { get; set; }
        public double? MaxHours { get; set; }
        public bool? Active { get; set; }
        public TimeSpan? ExactTimeFrom { get; set; }
        public TimeSpan? ExactTimeTo { get; set; }

        public virtual ICollection<MiscellaneousTask> MiscellaneousTasks { get; set; }
    }
}
