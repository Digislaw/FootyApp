﻿using Newtonsoft.Json;

namespace FootyApp.Model
{
    public class League
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("standings")]
        public List<List<Standing>> Standings { get; set; }
    }
}
