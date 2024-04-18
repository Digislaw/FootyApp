using Newtonsoft.Json;

namespace FootyApp.Model.Dto
{
    public class SquadDto
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("players")]
        public List<Player> Players { get; set; }
    }
}
