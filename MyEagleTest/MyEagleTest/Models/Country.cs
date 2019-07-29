using MongoDB.Bson.Serialization.Attributes;

namespace MyEagleTest.Models
{
    public class Country
    {
        [BsonElement("name")]
        public string Name { get; set; }
    }
}
