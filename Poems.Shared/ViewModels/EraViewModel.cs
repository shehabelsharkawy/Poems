using System;
using System.Collections.Generic;
using System.Text;

namespace Poems.Shared.ViewModels
{
    public class EraViewModel
    {
        public int EraId { get; set; }
        public string PoemEra { get; set; }

        public  ICollection<PoemViewModel> Poems { get; set; }
    }
}
