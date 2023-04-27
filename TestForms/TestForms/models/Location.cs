using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestForms.models
{
    internal class Location
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }
}
