using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace MyEagleTest.Models
{
    public class DriverLocation
    {
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("coordinates")]
        public List<decimal> Coordinates { get; set; }
    }
}
