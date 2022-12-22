using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service.Base.Interface
{
    public interface IServiceBaseCRUD<TEntity, TKey> where TEntity : Entity<TEntity, TKey>
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<TEntity> FindByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(int id);
    }
}
