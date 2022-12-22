using MagicAPI.Context;
using MagicAPI.Models;
using MagicAPI.Repository.Base.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Base
{
    public class RepositoryBaseCRUD<TEntity, TKey> : IRepositoryBaseCRUD<TEntity, TKey> where TEntity : Entity<TEntity, TKey>
    {

        #region Properties
        public DbSet<TEntity> dbSet { get; set; }
        private ApplicationDbContext _context;
        #endregion Properties

        #region Constructors
        public RepositoryBaseCRUD(ApplicationDbContext context)
        {
            dbSet = context.Set<TEntity>();
            _context = context;
        }
        #endregion Constructors

        #region Methods


        public virtual async Task AddAsync(TEntity obj)
        {
            await dbSet.AddAsync(obj);
        }

        public virtual async Task<TEntity> FindByIdAsync(int id)
        {
            var ret = await dbSet.FindAsync(id);
            return ret;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var listDb = await dbSet.AsNoTracking().ToListAsync();
            return listDb;
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            dbSet.Update(obj);
        }

        public virtual async Task RemoveAsync(int id)
        {
            dbSet.Remove(await dbSet.FindAsync(id));
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion Methods
    }
}
