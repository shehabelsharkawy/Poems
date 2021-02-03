using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Setting
    {
        public Setting()
        {
            SettingSteps = new HashSet<SettingStep>();
            SettingValues = new HashSet<SettingValue>();
        }

        public int SettingId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int? RoleId { get; set; }
        public int? DocumentType { get; set; }

        public virtual ICollection<SettingStep> SettingSteps { get; set; }
        public virtual ICollection<SettingValue> SettingValues { get; set; }
    }
}
