using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestForms.models
{
    internal class Characters
    {
        [JsonProperty("info")]
        public Info info { get; set; }

        [JsonProperty("results")]
        public List<Character> results { get; set; }
    }
}
