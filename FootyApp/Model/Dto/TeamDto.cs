using Newtonsoft.Json;

namespace FootyApp.Model
{
    public class TeamDto
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }
    }
}
