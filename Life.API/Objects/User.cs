using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Life.API.Objects
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [BsonElement("budgetId")]
        public string? BudgetId { get; set; }

        [BsonElement("userEmail")]
        public string? UserEmail { get; set; }

        [BsonElement("passwordHash")]
        public string? PasswordHash { get; set; }
    }
}
