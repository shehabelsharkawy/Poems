using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class BookFormat
    {
        public BookFormat()
        {
            ComplimentaryCopies = new HashSet<ComplimentaryCopy>();
            StockItems = new HashSet<StockItem>();
            Transactions = new HashSet<Transaction>();
        }

        public int BookFormatId { get; set; }
        public int BookId { get; set; }
        public int FormatId { get; set; }
        public string Isbn { get; set; }
        public int Edition { get; set; }

        public virtual Book Book { get; set; }
        public virtual Format Format { get; set; }
        public virtual ICollection<ComplimentaryCopy> ComplimentaryCopies { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
