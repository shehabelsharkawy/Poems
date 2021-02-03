using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Reason
    {
        public Reason()
        {
            ActionReasons = new HashSet<ActionReason>();
            DocumentActionReasons = new HashSet<DocumentActionReason>();
        }

        public int ReasonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsTranslationReason { get; set; }

        public virtual ICollection<ActionReason> ActionReasons { get; set; }
        public virtual ICollection<DocumentActionReason> DocumentActionReasons { get; set; }
    }
}
