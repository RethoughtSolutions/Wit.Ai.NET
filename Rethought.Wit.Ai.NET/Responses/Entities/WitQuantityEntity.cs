﻿using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitQuantityEntity : Entity
    {
        [JsonProperty("product")] public string Product { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("unit")] public string Unit { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}