using MongoDB.Driver;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Life.API.Interfaces;
using System.Diagnostics;
using MongoDB.Bson;

public class Repository<T> : IRepository<T>
{
    private readonly IMongoCollection<T> _collection;
    private readonly ILogger<Repository<T>> _logger;

    public Repository(MongoDBSettings settings, ILogger<Repository<T>> logger, string collectionName)
    {
        _logger = logger;
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        _collection = database.GetCollection<T>(collectionName);

        // Log that the connection has been established
        Debug.WriteLine($"Connected to MongoDB: Database '{settings.DatabaseName}' on '{settings.ConnectionString}'");
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _collection.Find(Builders<T>.Filter.Empty).ToListAsync();
    }

    public async Task<T> GetByIdAsync(ObjectId id)
    {
        return await _collection.Find(Builders<T>.Filter.Eq("_id", id)).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(T entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task<bool> UpdateAsync(ObjectId id, T entity)
    {
        var result = await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), entity);
        return result.IsAcknowledged && result.ModifiedCount > 0;
    }

    public async Task<bool> DeleteAsync(ObjectId id)
    {
        var result = await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id));
        return result.IsAcknowledged && result.DeletedCount > 0;
    }
}
