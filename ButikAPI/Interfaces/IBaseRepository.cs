namespace ButikAPI.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(int Id, T entity);
        Task DeleteAsync(int Id);
        Task SaveChangeAsync();
    }
}
