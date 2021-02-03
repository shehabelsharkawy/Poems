using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Workflow
    {
        public Workflow()
        {
            WorkflowSteps = new HashSet<WorkflowStep>();
        }

        public byte WorkflowId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }

        public virtual ICollection<WorkflowStep> WorkflowSteps { get; set; }
    }
}
