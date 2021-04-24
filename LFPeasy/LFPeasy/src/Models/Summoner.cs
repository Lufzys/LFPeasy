using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Summoner
{
    public class RerollPoints
    {
        [JsonProperty("currentPoints")]
        public int CurrentPoints { get; set; }

        [JsonProperty("maxRolls")]
        public int MaxRolls { get; set; }

        [JsonProperty("numberOfRolls")]
        public int NumberOfRolls { get; set; }

        [JsonProperty("pointsCostToRoll")]
        public int PointsCostToRoll { get; set; }

        [JsonProperty("pointsToReroll")]
        public int PointsToReroll { get; set; }
    }

    public class Root
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [JsonProperty("nameChangeFlag")]
        public bool NameChangeFlag { get; set; }

        [JsonProperty("percentCompleteForNextLevel")]
        public int PercentCompleteForNextLevel { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("rerollPoints")]
        public RerollPoints RerollPoints { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }

        [JsonProperty("unnamed")]
        public bool Unnamed { get; set; }

        [JsonProperty("xpSinceLastLevel")]
        public int XpSinceLastLevel { get; set; }

        [JsonProperty("xpUntilNextLevel")]
        public int XpUntilNextLevel { get; set; }
    }
}