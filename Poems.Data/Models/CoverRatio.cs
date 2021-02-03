using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class CoverRatio
    {
        public int CoverRatioId { get; set; }
        public byte RatioLeft { get; set; }
        public byte RatioRight { get; set; }
        public int DocumentType { get; set; }
        public string FolderName { get; set; }
    }
}
