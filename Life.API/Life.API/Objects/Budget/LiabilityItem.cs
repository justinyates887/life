using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Life.API.Objects.Budget
{
    public class LiabilityItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("monthlyBudgetItemId")]
        public string? MonthlyBudgetItemId { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("amountDue")]
        public float? AmountDue { get; set; }

        [BsonElement("minimumPaymentAmount")]
        public float? MinimumPaymentAmount { get; set; }

        [BsonElement("apr")]
        public float? APR { get; set; }
    }
}
