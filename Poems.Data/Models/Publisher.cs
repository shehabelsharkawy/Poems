using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Uri { get; set; }
        public string CopyRight { get; set; }
        public string UrlCode { get; set; }
        public int? ItemNumber { get; set; }
        public string EnglishName { get; set; }
        public string EnglishCopyright { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
