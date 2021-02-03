using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class SettingStep
    {
        public int SettingStepId { get; set; }
        public int SettingId { get; set; }
        public byte StepId { get; set; }

        public virtual Setting Setting { get; set; }
        public virtual Step Step { get; set; }
    }
}
