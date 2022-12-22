using MagicAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Application.Base.Interface
{
    public interface IApplicationBaseCRUD<TEntity, TKey> where TEntity : Entity<TEntity, TKey>
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<TEntity> FindByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(int id);
    }
}
