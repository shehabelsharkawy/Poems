using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class User
    {
        public User()
        {
            Invoices = new HashSet<Invoice>();
            PaymentReceipts = new HashSet<PaymentReceipt>();
            StockItems = new HashSet<StockItem>();
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? SupervisorId { get; set; }
        public bool Active { get; set; }
        public string Gender { get; set; }
        public int? ItemNumber { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
