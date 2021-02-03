using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poems.Shared
{
    public enum PoemEra
    {
        [Display(Name = "Active", ResourceType = typeof(PoemsResources))]
        Active = 1
    }

    public enum PoemLanguage
    {
        [Display(Name = "Active", ResourceType = typeof(PoemsResources))]
        Active = 1
    }

    public enum PoemStructure
    {
        [Display(Name = "Active", ResourceType = typeof(PoemsResources))]
        Active = 1

    }

    public enum PoemType
    {
        [Display(Name = "Active", ResourceType = typeof(PoemsResources))]
        Active = 1
    }
}
