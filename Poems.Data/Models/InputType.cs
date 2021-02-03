using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class InputType
    {
        public InputType()
        {
            BookInputTypes = new HashSet<BookInputType>();
            InputTypeCosts = new HashSet<InputTypeCost>();
        }

        public int InputTypeId { get; set; }
        public string InputTypeNameAr { get; set; }
        public string InputTypeNameEn { get; set; }
        public double Cost { get; set; }
        public double CostQc { get; set; }

        public virtual ICollection<BookInputType> BookInputTypes { get; set; }
        public virtual ICollection<InputTypeCost> InputTypeCosts { get; set; }
    }
}
