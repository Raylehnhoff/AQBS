using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class MatchPlayer
    {
        [JsonProperty(PropertyName = "player", Required = Required.Always)]
        public Player Player { get; set; }

        [JsonProperty("tossups_heard", Required = Required.Always)]
        public int TossupsHeard { get; set; }

        [JsonProperty("answer_counts", Required = Required.Always)]
        public IEnumerable<PlayerAnswerCount> AnswerCounts { get; set; }
    }
}