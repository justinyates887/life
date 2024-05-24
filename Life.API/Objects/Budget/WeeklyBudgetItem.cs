using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Life.API.Objects.Budget
{
    public class WeeklyBudgetItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("category")]
        public string? Category { get; set; }

        [BsonElement("amount")]
        public decimal? Amount { get; set; }

        [BsonElement("automated")]
        public bool? Automated { get; set; }

        [BsonElement("variable")]
        public bool? Variable { get; set; }
    }
}
