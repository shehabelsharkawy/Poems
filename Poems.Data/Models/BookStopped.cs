using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BookStopped
    {
        public int BookStoppedId { get; set; }
        public int BookId { get; set; }
        public string Reason { get; set; }
        public DateTime StopDate { get; set; }
        public int UserId { get; set; }
    }
}
