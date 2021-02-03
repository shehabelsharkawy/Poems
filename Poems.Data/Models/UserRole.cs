using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            DocumentTasks = new HashSet<DocumentTask>();
            MiscellaneousTasks = new HashSet<MiscellaneousTask>();
            PoemTasks = new HashSet<PoemTask>();
            RofoufStatusCoverUserRoles = new HashSet<RofoufStatus>();
            RofoufStatusDataUserRoles = new HashSet<RofoufStatus>();
            SettingValues = new HashSet<SettingValue>();
            Tasks = new HashSet<Task>();
        }

        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public byte RoleId { get; set; }
        public bool Active { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DocumentTask> DocumentTasks { get; set; }
        public virtual ICollection<MiscellaneousTask> MiscellaneousTasks { get; set; }
        public virtual ICollection<PoemTask> PoemTasks { get; set; }
        public virtual ICollection<RofoufStatus> RofoufStatusCoverUserRoles { get; set; }
        public virtual ICollection<RofoufStatus> RofoufStatusDataUserRoles { get; set; }
        public virtual ICollection<SettingValue> SettingValues { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
