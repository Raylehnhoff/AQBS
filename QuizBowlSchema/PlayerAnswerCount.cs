using Newtonsoft.Json;

namespace QuizBowlSchema
{
    public class PlayerAnswerCount
    {
        [JsonProperty(PropertyName = "number", Required = Required.Always)]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "AnswerType", Required = Required.Always)]
        public AnswerType AnswerType { get; set; }
    }
}