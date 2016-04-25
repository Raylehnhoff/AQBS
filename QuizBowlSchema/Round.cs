using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public class Round
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("packets")]
        public string Packets { get; set; }

        [JsonProperty("matches")]
        public IEnumerable<Match> Matches { get; set; }
    }
}