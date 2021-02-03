using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class TaskAction
    {
        public TaskAction()
        {
            ActionReasons = new HashSet<ActionReason>();
        }

        public int TaskActionId { get; set; }
        public string Action { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public int TaskId { get; set; }
        public int? TargetTaskId { get; set; }
        public bool? IsNormal { get; set; }
        public string Comment { get; set; }

        public virtual Task Task { get; set; }
        public virtual ICollection<ActionReason> ActionReasons { get; set; }
    }
}
