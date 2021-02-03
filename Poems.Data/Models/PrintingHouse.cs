using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PrintingHouse
    {
        public PrintingHouse()
        {
            StockItems = new HashSet<StockItem>();
        }

        public int PrintingHouseId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
