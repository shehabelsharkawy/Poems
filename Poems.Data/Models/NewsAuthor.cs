using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class NewsAuthor
    {
        public int AuthorId { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public string Bio { get; set; }
        public int ItemNumber { get; set; }
    }
}
