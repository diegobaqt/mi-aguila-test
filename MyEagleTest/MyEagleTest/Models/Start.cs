using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyEagleTest.Models
{
    public class Start
    {
        [BsonElement("date")]
        public Date Date { get; set; }

        [BsonElement("pickup_address")]
        [JsonProperty("pickup_address")]
        public string PickupAddress { get; set; }

        [BsonElement("pickup_location")]
        [JsonProperty("pickup_location")]
        public PickupLocation PickupLocation { get; set; }
    }
}
