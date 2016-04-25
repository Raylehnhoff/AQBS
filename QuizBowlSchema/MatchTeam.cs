using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace QuizBowlSchema
{
    public class MatchTeam
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("forefeit_loss")]
        public bool? IsForefeitLoss { get; set; }

        [JsonProperty("points")]
        public int? Points { get; set; }

        [JsonProperty("bonus_points")]
        public int? BonusPoints { get; set; }

        [JsonProperty("correct_tossups_without_bonuses")]
        public int? CorrectTossupsWithoutBonuses { get; set; }

        [JsonProperty("bonus_bounceback_points")]
        public int? BonusBouncebackPoints { get; set; }

        [JsonProperty("lightning_points")]
        public int? LightningPoints { get; set; }

        [JsonProperty("lightning_bounceback_points")]
        public int? LightningBouncebackPoints { get; set; }

        [JsonProperty("match_players")]
        public IEnumerable<MatchPlayer> MatchPlayers { get; set; }

        [JsonProperty("lineups")]
        public IEnumerable<Lineup> Lineups { get; set; }

        [JsonProperty("suppress_from_statistics")]
        public bool? SuppressFromStatistics { get; set; }
    }
}