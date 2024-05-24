using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Life.API.Objects.Budget
{
    public class LiquidAssetItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("amount")]
        public float? Amount { get; set; }

        [BsonElement("apr")]
        public float? APR { get; set; }
    }
}
