using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace MyEagleTest.Models
{
    public class PickupLocation
    {
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("coordinates")]
        public List<decimal> Coordinates { get; set; }
    }
}
