using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TrabalhandoComTasks.Data.Contexts;
using TrabalhandoComTasks.Domain.Contracts.Repositories.Generic;
using TrabalhandoComTasks.Domain.Shared.Entities;

namespace TrabalhandoComTasks.Data.Repositories.Generic
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        protected readonly TasksContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(TasksContext context)
        {
            this._context = context;
            this._dbSet = this._context.Set<T>();
        }

        public async Task<T> Save(T e)
        {
            await this._dbSet.AddAsync(e);
            _context.SaveChanges();

            return await Task.FromResult(e);
        }

        public async Task<T> Update(T e)
        {
            this._dbSet.Update(e);
            _context.SaveChanges();

            return await Task.FromResult(e);
        }

        public async Task<T> Delete(T e)
        {
            this._dbSet.Remove(e);
            _context.SaveChanges(); 

            return await Task.FromResult(e);
        }
    }
}
