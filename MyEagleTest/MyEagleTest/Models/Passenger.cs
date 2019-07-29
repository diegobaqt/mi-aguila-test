using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyEagleTest.Models
{
    public class Passenger
    {
        [BsonElement("first_name")]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
