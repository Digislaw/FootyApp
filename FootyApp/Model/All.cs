using Newtonsoft.Json;

namespace FootyApp.Model
{
    /// <summary>
    /// Punktacja ogólna (Home + Away)
    /// </summary>
    public class All
    {
        [JsonProperty("played")]
        public int Played { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }

        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("lose")]
        public int Lose { get; set; }

        //[JsonProperty("goals")]
        //public Goals Goals { get; set; }
    }
}
