using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyEagleTest.Models
{
    [BsonIgnoreExtraElements]
    public class Trip
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("start")]
        public Start Start { get; set; }

        [BsonElement("end")]
        public End End { get; set; }

        [BsonElement("country")]
        public Country Country { get; set; }

        [BsonElement("city")]
        public City City { get; set; }

        [BsonElement("passenger")]
        public Passenger Passenger { get; set; }

        [BsonElement("driver")]
        public Driver Driver { get; set; }

        [BsonElement("car")]
        public Car Car { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("check_code")]
        [JsonProperty("check_code")]
        public string CheckCode { get; set; }

        [BsonElement("createdAt")]
        public CreatedAt CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        public UpdatedAt UpdatedAt { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("driver_location")]
        [JsonProperty("driver_location")]
        public DriverLocation DriverLocation { get; set; }
    }
}
