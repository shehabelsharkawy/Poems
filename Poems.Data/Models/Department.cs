using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Notes { get; set; }
    }
}
