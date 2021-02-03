using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DocumentStopped
    {
        public int DocumentStoppedId { get; set; }
        public int DocumentId { get; set; }
        public string Reason { get; set; }
        public DateTime StopDate { get; set; }
        public int UserId { get; set; }
    }
}
