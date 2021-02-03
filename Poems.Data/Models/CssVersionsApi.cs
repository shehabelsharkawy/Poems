using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class CssVersionsApi
    {
        public int Id { get; set; }
        public int? Version { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int DestinationType { get; set; }
        public int? Type { get; set; }
        public int? DeviceType { get; set; }
        public bool FileType { get; set; }
        public int? Csstype { get; set; }
    }
}
