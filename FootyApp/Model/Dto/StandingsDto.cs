using Newtonsoft.Json;

namespace FootyApp.Model.Dto
{
    public class StandingsDto
    {
        [JsonProperty("league")]
        public League League { get; set; }
    }
}
