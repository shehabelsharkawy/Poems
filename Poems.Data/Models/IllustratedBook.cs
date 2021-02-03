using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class IllustratedBook
    {
        public int IllustratedBookId { get; set; }
        public int DocumentId { get; set; }
        public int? AfterAcquisitionStep { get; set; }
        public int? OnlineOptions { get; set; }
        public int BookType { get; set; }
        public int? OrderInSeries { get; set; }
        public string SeriesPrefix { get; set; }
    }
}
