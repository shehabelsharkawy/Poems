using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class PriorityQueue
    {
        public int PriorityId { get; set; }
        public string PriorityName { get; set; }
        public int Weight { get; set; }
        public int QueueType { get; set; }
    }
}
