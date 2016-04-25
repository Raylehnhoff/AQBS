using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public class MatchQuestion
    {
        [JsonProperty(PropertyName = "buzzes", Required = Required.Always)]
        public IEnumerable<MatchQuestionBuzz> Buzzes { get; set; }

        [JsonProperty("bonus_points")]
        public int? BonusPoints { get; set; }

        [JsonProperty("bounceback_bonus_points")]
        public int? BouncebackBonusPoints { get; set; }
    }
}