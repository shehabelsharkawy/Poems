using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Isbnregistration
    {
        public int IsbnregistrationId { get; set; }
        public int BookId { get; set; }
        public string OriginalIsbn { get; set; }
        public string PrintedIsbn { get; set; }
        public string PrintedRegistrationNumber { get; set; }
        public string DigitalIsbn { get; set; }
        public string DigitalRegistrationNumber { get; set; }
    }
}
