using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Series
    {
        public Series()
        {
            Books = new HashSet<Book>();
        }

        public int SeriesId { get; set; }
        public string TitleArabic { get; set; }
        public string TitleEnglish { get; set; }
        public string BlurbArabic { get; set; }
        public string BlurbEnglish { get; set; }
        public int ItemNumber { get; set; }
        public bool IsTashkeel { get; set; }
        public bool HasCover { get; set; }
        public bool IsKartoniat { get; set; }
        public int SeriesType { get; set; }
        public bool IsApproved { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
