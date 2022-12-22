using MagicAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Base.Interface
{
    public interface IRepositoryBaseCRUD<TEntity, TKey>: IDisposable where TEntity : Entity<TEntity, TKey>
    {
        Task AddAsync(TEntity obj);
        Task<TEntity> FindByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(int id);
        int Save();
    }
}
