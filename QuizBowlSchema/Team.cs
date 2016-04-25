using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public class Team
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "players")]
        public IEnumerable<Player> Players { get; set; }

        [JsonProperty(PropertyName = "ranks")]
        public IEnumerable<Rank> Ranks { get; set; }
    }
}