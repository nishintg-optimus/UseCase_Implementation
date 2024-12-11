using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UseCaseRJ.application.contract.persistence;

namespace UseCaseRJ.persistence.Repositories
{
    public class GenericRepositoriesImplementation<T> : IGenericRepository<T> where T : class
    {
        private readonly UseCaseRJDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepositoriesImplementation(UseCaseRJDbContext context)
        {
            _dbContext= context;
            _dbSet=_dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entitiy)
        {
            _dbSet.Remove(entitiy);
            await _dbContext.SaveChangesAsync();
        }
    }

}
