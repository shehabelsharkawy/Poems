using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentActionReason
    {
        public int ActionReasonId { get; set; }
        public int TaskActionId { get; set; }
        public int ReasonId { get; set; }

        public virtual Reason Reason { get; set; }
        public virtual DocumentTaskAction TaskAction { get; set; }
    }
}
