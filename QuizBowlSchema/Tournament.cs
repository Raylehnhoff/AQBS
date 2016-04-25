using Newtonsoft.Json;
using QuizBowlSchema.Extensions;
using System;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class Tournament
    {
        private Difficulty _difficulty;
        private TournamentLevel _level;

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("level")]
        public string Level
        {
            get
            {
                return _level.ToDescription();
            }
            set
            {
                _level = (TournamentLevel)Enum.Parse(typeof(TournamentLevel), value);
            }
        }

        [JsonProperty("difficulty")]
        public string Difficulty
        {
            get
            {
                return _difficulty.ToDescription();
            }
            set
            {
                _difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), value);
            }
        }

        [JsonProperty("phases")]
        public IEnumerable<Phase> Phases { get; set; }

        public IEnumerable<Ranking> Rankings { get; set; }

        [JsonProperty("registrations")]
        public IEnumerable<Registration> Registrations { get; set; }

        [JsonProperty("scoring_rules")]
        public ScoringRules ScoringRules { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("tournament_site")]
        public TournamentSite TournamentSite { get; set; }

        [JsonProperty("question_set")]
        public string QuestionSet { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }
}