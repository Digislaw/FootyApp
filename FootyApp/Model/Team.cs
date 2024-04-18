using Newtonsoft.Json;

namespace FootyApp.Model
{
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("founded")]
        public int Founded { get; set; }

        [JsonProperty("national")]
        public bool National { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}