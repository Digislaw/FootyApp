using Newtonsoft.Json;

namespace FootyApp.Model
{
    public class Venue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("surface")]
        public string Surface { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
