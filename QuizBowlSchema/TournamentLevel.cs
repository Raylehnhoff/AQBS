using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public enum TournamentLevel
    {
        Unknown = 0,

        [JsonProperty("middle_school")]
        [Display(Description = "middle_school")]
        MiddleSchool = 1,

        [JsonProperty("high_school")]
        [Display(Description = "high_school")]
        HighSchool = 2,

        [JsonProperty("college")]
        [Display(Description = "college")]
        College = 3,

        [JsonProperty("open")]
        [Display(Description = "open")]
        Open = 4,

        [JsonProperty("trash")]
        [Display(Description = "trash")]
        Trash = 5,

        [JsonProperty("other")]
        [Display(Description = "other")]
        Other = 6
    }
}