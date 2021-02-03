using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class SettingValue
    {
        public int SettingValueId { get; set; }
        public int SettingId { get; set; }
        public decimal Value { get; set; }
        public string ValueString { get; set; }
        public DateTime? Date { get; set; }
        public int? BookId { get; set; }
        public int? UserRoleId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Setting Setting { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
