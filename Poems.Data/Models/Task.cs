using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class Task
    {
        public Task()
        {
            AchievedWordsCounts = new HashSet<AchievedWordsCount>();
            TaskActions = new HashSet<TaskAction>();
            TaskFreelancers = new HashSet<TaskFreelancer>();
            TranslationDetails = new HashSet<TranslationDetail>();
            WaitingLists = new HashSet<WaitingList>();
        }

        public int TaskId { get; set; }
        public int BookId { get; set; }
        public int? UserRoleId { get; set; }
        public byte WorkflowStepId { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? Pes { get; set; }
        public int? Fes { get; set; }
        public int? Extras { get; set; }
        public short? WorkHours { get; set; }
        public decimal? HourCost { get; set; }
        public double? FixedCost { get; set; }
        public int PreviousTaskId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ActualStartDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ResetAchievedCount ResetAchievedCount { get; set; }
        public virtual ICollection<AchievedWordsCount> AchievedWordsCounts { get; set; }
        public virtual ICollection<TaskAction> TaskActions { get; set; }
        public virtual ICollection<TaskFreelancer> TaskFreelancers { get; set; }
        public virtual ICollection<TranslationDetail> TranslationDetails { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
    }
}
