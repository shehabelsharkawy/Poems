using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Step
    {
        public Step()
        {
            DocumentTasks = new HashSet<DocumentTask>();
            SettingSteps = new HashSet<SettingStep>();
            WorkflowSteps = new HashSet<WorkflowStep>();
        }

        public byte StepId { get; set; }
        public string StepTitle { get; set; }
        public bool IsRequired { get; set; }
        public string StepNote { get; set; }
        public decimal? InitialHourCost { get; set; }
        public bool Active { get; set; }
        public int? Weight { get; set; }

        public virtual ICollection<DocumentTask> DocumentTasks { get; set; }
        public virtual ICollection<SettingStep> SettingSteps { get; set; }
        public virtual ICollection<WorkflowStep> WorkflowSteps { get; set; }
    }
}
