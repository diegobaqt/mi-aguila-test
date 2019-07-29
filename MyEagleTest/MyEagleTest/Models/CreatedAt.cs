using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyEagleTest.Models
{
    public class CreatedAt
    {
        [BsonElement("date")]
        [JsonProperty("$date")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
