using Newtonsoft.Json;

namespace FootyApp.Model
{
    public class Standing
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("goalsDiff")]
        public int GoalsDiff { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("all")]
        public All All { get; set; }

        //[JsonProperty("home")]
        //public Home Home { get; set; }

        //[JsonProperty("away")]
        //public Away Away { get; set; }

        [JsonProperty("update")]
        public DateTime Update { get; set; }
    }
}
