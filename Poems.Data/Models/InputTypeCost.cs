using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class InputTypeCost
    {
        public int Id { get; set; }
        public int InputTypeId { get; set; }
        public double Cost { get; set; }
        public double CostQc { get; set; }
        public DateTime CostDate { get; set; }

        public virtual InputType InputType { get; set; }
    }
}
