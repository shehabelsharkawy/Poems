using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentTaskAction
    {
        public DocumentTaskAction()
        {
            DocumentActionReasons = new HashSet<DocumentActionReason>();
        }

        public int TaskActionId { get; set; }
        public string Action { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public int DocumentTasksId { get; set; }
        public int? TargetTaskId { get; set; }
        public bool? IsNormal { get; set; }
        public string Comment { get; set; }

        public virtual DocumentTask DocumentTasks { get; set; }
        public virtual ICollection<DocumentActionReason> DocumentActionReasons { get; set; }
    }
}
