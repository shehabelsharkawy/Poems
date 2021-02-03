using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class MarktingPlan
    {
        public int MarktingPlanId { get; set; }
        public int DocumentId { get; set; }
        public bool HasMarktingPlan { get; set; }
        public DateTime StartDate { get; set; }
        public bool PlanFinished { get; set; }
        public DateTime? FinishedDate { get; set; }

        public virtual Book Document { get; set; }
    }
}
