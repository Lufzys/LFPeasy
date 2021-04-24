using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Chat
{
    public class Lol
    {
        [JsonProperty("championId")]
        public string ChampionId { get; set; }

        [JsonProperty("companionId")]
        public string CompanionId { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("gameQueueType")]
        public string GameQueueType { get; set; }

        [JsonProperty("gameStatus")]
        public string GameStatus { get; set; }

        [JsonProperty("initRankStat")]
        public string InitRankStat { get; set; }

        [JsonProperty("isObservable")]
        public string IsObservable { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("mapId")]
        public string MapId { get; set; }

        [JsonProperty("pty")]
        public string Pty { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("queueId")]
        public string QueueId { get; set; }

        [JsonProperty("regalia")]
        public string Regalia { get; set; }

        [JsonProperty("skinVariant")]
        public string SkinVariant { get; set; }

        [JsonProperty("skinname")]
        public string Skinname { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }

    public class Root
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("gameName")]
        public string GameName { get; set; }

        [JsonProperty("gameTag")]
        public string GameTag { get; set; }

        [JsonProperty("icon")]
        public int Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastSeenOnlineTimestamp")]
        public object LastSeenOnlineTimestamp { get; set; }

        [JsonProperty("lol")]
        public Lol Lol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("patchline")]
        public string Patchline { get; set; }

        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }
    }
}
