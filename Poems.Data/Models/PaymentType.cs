using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            PaymentReceipts = new HashSet<PaymentReceipt>();
        }

        public int PaymentTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
    }
}
