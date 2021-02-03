using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Dnslog
    {
        public int Id { get; set; }
        public int? ActionId { get; set; }
        public int? UserRoleId { get; set; }
        public DateTime? Date { get; set; }
        public string ClientName { get; set; }
        public string PageName { get; set; }
        public int? ItemNumber { get; set; }
        public int? TableAction { get; set; }
        public int? LogType { get; set; }
        public string LogValue { get; set; }
    }
}
