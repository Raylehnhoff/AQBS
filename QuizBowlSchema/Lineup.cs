using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class Lineup
    {
        [JsonProperty(PropertyName = "first_question", Required = Required.Always)]
        public int FirstQuestion { get; set; }

        [JsonProperty(PropertyName = "players", Required = Required.Always)]
        public IEnumerable<Player> Players { get; set; }

        [JsonProperty(PropertyName = "reason", Required = Required.Always)]
        public string Reason { get; set; }
    }
}