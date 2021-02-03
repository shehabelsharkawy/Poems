using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class MiscellaneousTask
    {
        public int MiscellaneousTaskId { get; set; }
        public int UserRoleId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int MiscellaneousTaskTypeId { get; set; }
        public bool? Approved { get; set; }

        public virtual MiscellaneousTaskType MiscellaneousTaskType { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
