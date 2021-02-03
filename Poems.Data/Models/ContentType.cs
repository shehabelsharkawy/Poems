using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ContentType
    {
        public int ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
        public int ItemNumber { get; set; }
    }
}
