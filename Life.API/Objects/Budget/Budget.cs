using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

/*
 * This object will hate a tax rate member for MVP. Eventually, I would like to automatically find state, federal, and locale tax rates for user.
 */

namespace Life.API.Objects.Budget
{
    public class Budget
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("grossIncome")]
        public int? GrossIncome { get; set; }

        [BsonElement("taxableState")]
        public string? TaxableState { get; set; }

        [BsonElement("taxableLocale")]
        public string? TaxableLocale { get; set; }

        [BsonElement("stateTaxRate")]
        public float? stateTaxRate { get; set; }

        [BsonElement("localeTaxRate")]
        public float? localeTaxRate { get; set; }

        [BsonElement("weeklyItems")]
        public List<WeeklyBudgetItem>? WeeklyItems { get; set; }

        [BsonElement("monthlyItems")]
        public List<MonthlyBudgetItem>? MonthlyItems { get; set; }

        [BsonElement("liabilityItems")]
        public List<LiabilityItem>? LiabilityItems { get; set; }

        [BsonElement("liquidAssetItems")]
        public List<LiquidAssetItem>? LiquidAssetItems { get; set; }
    }
}
