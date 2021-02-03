using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class WaitingList
    {
        public int WaitingListId { get; set; }
        public int? TaskId { get; set; }
        public bool? Active { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Task Task { get; set; }
    }
}
