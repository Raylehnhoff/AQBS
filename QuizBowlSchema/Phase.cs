using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class Phase
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rounds")]
        public IEnumerable<Round> Rounds { get; set; }

        [JsonProperty("cards_traded")]
        public bool? CardsTraded { get; set; }

        [JsonProperty("pools")]
        public IEnumerable<Pool> Pools { get; set; }
    }
}