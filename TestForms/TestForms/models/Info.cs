using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestForms.models
{
    internal class Info
    {
        [JsonProperty("count")]
        public int? count { get; set; }

        [JsonProperty("pages")]
        public int? pages { get; set; }

        [JsonProperty("next")]
        public string next { get; set; }

        [JsonProperty("prev")]
        public string prev { get; set; }
    }
}
