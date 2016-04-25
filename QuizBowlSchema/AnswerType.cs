using Newtonsoft.Json;

namespace QuizBowlSchema
{
    public class AnswerType
    {
        [JsonProperty(PropertyName = "value", Required = Required.Always)]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("short_label")]
        public string ShortLabel { get; set; }

        [JsonProperty("awards_bonus")]
        public bool? AwardsBonus { get; set; }
    }
}