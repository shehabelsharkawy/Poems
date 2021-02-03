using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class WorkflowStep
    {
        public WorkflowStep()
        {
            WorkflowStepRoles = new HashSet<WorkflowStepRole>();
        }

        public byte WorkflowStepId { get; set; }
        public byte WorkflowId { get; set; }
        public byte StepId { get; set; }
        public bool Active { get; set; }

        public virtual Step Step { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<WorkflowStepRole> WorkflowStepRoles { get; set; }
    }
}
