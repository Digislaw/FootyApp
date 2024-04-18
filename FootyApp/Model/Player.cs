using Newtonsoft.Json;

namespace FootyApp.Model
{
    public class Player
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }
    }
}
