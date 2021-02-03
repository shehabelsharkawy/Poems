using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class RolePermission
    {
        public int RolePermissionId { get; set; }
        public byte RoleId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Module { get; set; }
        public bool MainLink { get; set; }
        public string RouteType { get; set; }

        public virtual Role Role { get; set; }
    }
}
