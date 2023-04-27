using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestForms.models
{
    internal class Character
    {
        [JsonProperty("id")]
        public int? id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("species")]
        public string species { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("origin")]
        public Origin origin { get; set; }

        [JsonProperty("location")]
        public Location location { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("episode")]
        public List<string> episode { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("created")]
        public string created { get; set; }
    }
}
