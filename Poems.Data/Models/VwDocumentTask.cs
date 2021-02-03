using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class VwDocumentTask
    {
        public int DocumentTasksId { get; set; }
        public int DocumentId { get; set; }
        public int? UserRoleId { get; set; }
        public byte StepId { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? Pes { get; set; }
        public int? Fes { get; set; }
        public short? WorkHours { get; set; }
        public decimal? HourCost { get; set; }
        public double? FixedCost { get; set; }
        public int PreviousTaskId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ActualStartDate { get; set; }
    }
}
