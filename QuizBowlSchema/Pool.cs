using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class Pool
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("pools_teams")]
        public IEnumerable<PoolTeam> PoolTeams { get; set; }
    }
}