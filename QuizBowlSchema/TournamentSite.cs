using Newtonsoft.Json;

namespace QuizBowlSchema
{
    public class TournamentSite
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("latitude")]
        public int? Latitude { get; set; }

        [JsonProperty("longitude")]
        public int? Longitude { get; set; }
    }
}