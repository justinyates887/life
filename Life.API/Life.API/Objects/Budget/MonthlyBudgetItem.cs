using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class MonthlyBudgetItem
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

    [BsonElement("date")]
    public DateTime? Date { get; set; }

    [BsonElement("automated")]
    public bool? Automated { get; set; }

    [BsonElement("variable")]
    public bool? Variable { get; set; }

    [BsonElement("isDiscretionary")]
    public bool? IsDiscretionary { get; set; }
}
