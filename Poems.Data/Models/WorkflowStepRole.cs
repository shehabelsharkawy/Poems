using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class WorkflowStepRole
    {
        public short WorkflowStepRoleId { get; set; }
        public byte WorkflowStepId { get; set; }
        public byte RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual WorkflowStep WorkflowStep { get; set; }
    }
}
