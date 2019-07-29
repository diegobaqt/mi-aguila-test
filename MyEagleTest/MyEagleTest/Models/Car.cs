using MongoDB.Bson.Serialization.Attributes;

namespace MyEagleTest.Models
{
    public class Car
    {
        [BsonElement("plate")]
        public string Plate { get; set; }
    }
}
