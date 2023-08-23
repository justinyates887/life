using Life.API.Models;
using Life.API.Models.Budget;
using MongoDB.Driver;

namespace Life.Data
{
    public class DataContext
    {
        private readonly IMongoDatabase _database;

        public DataContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<BudgetModel> Budgets => _database.GetCollection<BudgetModel>("budgets");

        public IMongoCollection<UserModel> Users => _database.GetCollection<UserModel>("users");
    }
}
