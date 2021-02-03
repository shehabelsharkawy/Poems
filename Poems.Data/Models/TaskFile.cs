using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class TaskFile
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public int TaskId { get; set; }
        public byte Version { get; set; }
        public DateTime UploadDate { get; set; }
        public string FilePath { get; set; }
        public int? FileType { get; set; }

        public virtual File File { get; set; }
    }
}
