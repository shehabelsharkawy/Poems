using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PaymentState
    {
        public PaymentState()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
