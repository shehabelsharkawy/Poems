using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class KartoniatAd
    {
        public int AdsId { get; set; }
        public int AdTypeId { get; set; }
        public int AdScreenId { get; set; }
        public string Url { get; set; }
        public int? ItemNumber { get; set; }
        public int UserRoleId { get; set; }
        public DateTime InsertionDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsArchive { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public string ImagePath { get; set; }
        public Guid Guid { get; set; }

        public virtual AdScreen AdScreen { get; set; }
        public virtual AdType AdType { get; set; }
    }
}
