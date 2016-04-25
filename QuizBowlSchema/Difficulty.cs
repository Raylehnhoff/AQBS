using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public enum Difficulty
    {
        Unknown = 0,

        [Display(Description = "novice")]
        Novice = 1,

        [Display(Description = "regular")]
        Regular = 2,

        [Display(Description = "nationals")]
        Nationals = 3
    }
}