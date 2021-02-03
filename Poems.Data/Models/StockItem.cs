using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class StockItem
    {
        public int StockItemId { get; set; }
        public int BookFormatId { get; set; }
        public int PrintingHouseId { get; set; }
        public int PrintedCopies { get; set; }
        public DateTime ReceivingDate { get; set; }
        public int StaffId { get; set; }
        public DateTime InsertionDate { get; set; }

        public virtual BookFormat BookFormat { get; set; }
        public virtual PrintingHouse PrintingHouse { get; set; }
        public virtual User Staff { get; set; }
    }
}
