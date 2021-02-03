using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BookActiveAgain
    {
        public int Id { get; set; }
        public int BookStoppedId { get; set; }
        public int BookId { get; set; }
        public string Reason { get; set; }
        public DateTime StoppDate { get; set; }
        public int UserId { get; set; }
        public DateTime ActiveAgainDate { get; set; }
    }
}
