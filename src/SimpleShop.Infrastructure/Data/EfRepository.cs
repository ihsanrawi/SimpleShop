using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleShop.ApplicationCore.Entities;
using SimpleShop.ApplicationCore.Interfaces;

namespace SimpleShop.Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _ctx;

        public EfRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }
        
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _ctx.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            _ctx.Set<T>().Add(entity);
            await _ctx.SaveChangesAsync();

            return entity;
        }
        
        public async Task UpdateAsync(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            await _ctx.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            await _ctx.SaveChangesAsync();
        }
    }
}