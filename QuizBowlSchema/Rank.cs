using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public class Rank
    {
        [JsonProperty(PropertyName = "ranking", Required = Required.Always)]
        public Ranking Ranking { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }
    }
}