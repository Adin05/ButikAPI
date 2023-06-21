using ButikAPI.Data;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ButikAPI.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly DataContext _context;
        private DbSet<T> entities;

        public BaseRepository(DataContext context)
        {
            this._context = context;
            entities = _context.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await entities.FindAsync(Id);
            entities.Remove(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await entities.FindAsync(Id);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int Id, T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
