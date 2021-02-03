using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ChannelLocation
    {
        public ChannelLocation()
        {
            Invoices = new HashSet<Invoice>();
            PaymentReceipts = new HashSet<PaymentReceipt>();
        }

        public int ChannelLocationId { get; set; }
        public int ChannelId { get; set; }
        public int CountryId { get; set; }
        public int? Year { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
    }
}
