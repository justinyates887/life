namespace Life.API.Interfaces
{
    using MongoDB.Bson;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(ObjectId id);
        Task CreateAsync(T entity);
        Task<bool> UpdateAsync(ObjectId id, T entity);
        Task<bool> DeleteAsync(ObjectId id);
    }

}
