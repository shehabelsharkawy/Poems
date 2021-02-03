using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserRoles = new HashSet<UserRole>();
            WorkflowStepRoles = new HashSet<WorkflowStepRole>();
        }

        public byte RoleId { get; set; }
        public string RoleTitle { get; set; }
        public bool Active { get; set; }
        public string UrlName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<WorkflowStepRole> WorkflowStepRoles { get; set; }
    }
}
