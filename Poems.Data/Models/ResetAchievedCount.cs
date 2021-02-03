using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ResetAchievedCount
    {
        public int ResetAchievedCountId { get; set; }
        public int TaskId { get; set; }
        public bool? ResetCount { get; set; }

        public virtual Task Task { get; set; }
    }
}
