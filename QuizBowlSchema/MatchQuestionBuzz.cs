using Newtonsoft.Json;

namespace QuizBowlSchema
{
    public class MatchQuestionBuzz
    {
        [JsonProperty(PropertyName = "team", Required = Required.Always)]
        public Team Team { get; set; }

        [JsonProperty(PropertyName = "player", Required = Required.Always)]
        public Player Player { get; set; }

        [JsonProperty(PropertyName = "result", Required = Required.Always)]
        public AnswerType Result { get; set; }
    }
}