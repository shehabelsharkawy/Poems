using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class File
    {
        public File()
        {
            TaskFiles = new HashSet<TaskFile>();
        }

        public int FileId { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<TaskFile> TaskFiles { get; set; }
    }
}
