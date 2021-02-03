using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class LogDownloadIssueImage
    {
        public int LogDownloadIssueImagesId { get; set; }
        public int? LogType { get; set; }
        public int? ItemNumber { get; set; }
        public string LogPath { get; set; }
        public string LogError { get; set; }
    }
}
