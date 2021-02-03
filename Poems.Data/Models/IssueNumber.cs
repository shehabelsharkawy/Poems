using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class IssueNumber
    {
        public IssueNumber()
        {
            Books = new HashSet<Book>();
        }

        public int IssueId { get; set; }
        public string IssueNumber1 { get; set; }
        public string Year { get; set; }
        public int? ItemNumber { get; set; }
        public int? Status { get; set; }
        public bool HasCover { get; set; }
        public DateTime? UploadDate { get; set; }
        public bool HasTitle { get; set; }
        public bool HasOriginal { get; set; }
        public int? BestCoverItemNumber { get; set; }
        public string IssueTitle { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
