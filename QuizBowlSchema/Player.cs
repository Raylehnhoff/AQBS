using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public class Player
    {
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        private Year _year;

        [JsonProperty("year")]
        public int Year
        {
            get
            {
                return (int)_year;
            }
            set
            {
                _year = (Year)value;
            }
        }
    }
}