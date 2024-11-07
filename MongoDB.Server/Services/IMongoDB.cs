namespace MongoDB.Server.Services
{
    public interface IMongoDB <T>
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T item);
        Task UpdateAsync(string id, T item);
        Task SyncedAsync(string itemID);
        Task DeleteAsync(string id);
    }
}
