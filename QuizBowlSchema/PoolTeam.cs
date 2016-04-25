using Newtonsoft.Json;

namespace QuizBowlSchema
{
    public class PoolTeam
    {
        [JsonProperty(PropertyName = "pool", Required = Required.Always)]
        public Pool Pool { get; set; }

        [JsonProperty(PropertyName = "team", Required = Required.Always)]
        public Team Team { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }
    }
}