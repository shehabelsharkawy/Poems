using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class ExternalReport
    {
        public int ExternalReportId { get; set; }
        public string ReportTitle { get; set; }
        public string RouteUrl { get; set; }
        public string DomainUrl { get; set; }
        public string Type { get; set; }
        public string TypePrefix { get; set; }
        public int Order { get; set; }
        public bool? Active { get; set; }
        public bool MainDisplay { get; set; }
    }
}
