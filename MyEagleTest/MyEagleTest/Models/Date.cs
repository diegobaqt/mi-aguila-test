using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyEagleTest.Models
{
    public class Date
    {
        [BsonElement("date")]
        [JsonProperty("$date")]
        public DateTime DateTime { get; set; }
    }
}
