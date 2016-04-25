using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBowlSchema
{
    public class Match
    {
        [JsonProperty("tossups_read")]
        public int? TossupsRead { get; set; }

        [JsonProperty("overtime_tossups_read")]
        public int? OvertimeTossupsRead { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("tiebreaker")]
        public bool? IsTiebreaker { get; set; }

        [JsonProperty("moderator")]
        public string Moderator { get; set; }

        [JsonProperty("scorekeeper")]
        public string Scorekeeper { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty(PropertyName = "match_teams", Required = Required.Always)]
        public IEnumerable<MatchTeam> MatchTeams { get; set; }

        [JsonProperty("carryover_phases")]
        public IEnumerable<Phase> CarryoverPhases { get; set; }

        [JsonProperty("match_questions")]
        public IEnumerable<MatchQuestion> MatchQuestions { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}