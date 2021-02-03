using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class UrlSourceTitle
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string NewTitle { get; set; }
    }
}
