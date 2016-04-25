using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizBowlSchema
{
    public class Registration
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "teams", Required = Required.Always)]
        public IEnumerable<Team> Teams { get; set; }
    }
}