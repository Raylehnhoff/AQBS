using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class ScoringRules
    {
        [JsonProperty("teams_per_match")]
        public int? TeamsPerMatch { get; set; } = 2;

        [JsonProperty("maximum_players_per_team")]
        public int? MaximumPlayersPerTeam { get; set; } = 4;

        [JsonProperty("regulation_tossup_count")]
        public int? RegulationTossupCount { get; set; } = 20;

        [JsonProperty("maximum_regulation_tossup_count")]
        public int? MaximumRegulationTossupCount { get; set; } = 20;

        [JsonProperty("minimum_overtime_question_count")]
        public int? MinimumOvertimeQuestionCount { get; set; } = 1;

        [JsonProperty("overtime_includes_bonuses")]
        public bool? OvertimeIncludesBonuses { get; set; } = false;

        [JsonProperty("total_divisor")]
        public int? TotalDivisor { get; set; } = 5;

        [JsonProperty("maximum_bonus_score")]
        public int? MaximumBonusScore { get; set; }

        [JsonProperty("bonus_divisor")]
        public int? BonusDivisor { get; set; }

        [JsonProperty("bonuses_bounce_back")]
        public bool? BonusesBounceBack { get; set; }

        [JsonProperty("lightning_count_per_team")]
        public int? LightningCountPerTeam { get; set; } = 0;

        [JsonProperty("maximum_lightning_score")]
        public int? MaximumLightningScore { get; set; }

        [JsonProperty("lightning_divisor")]
        public int? LightningDivisor { get; set; }

        [JsonProperty("lightnings_bounce_back")]
        public bool? LightningBounceBack { get; set; }

        [JsonProperty(PropertyName = "answer_types", Required = Required.Always)]
        public IEnumerable<AnswerType> AnswerTypes { get; set; }
    }
}