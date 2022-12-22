using MagicAPI.Models;
using MagicAPI.Repository.Base.Interface;
using MagicAPI.Service.Base.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service.Base
{
    public class ServiceBaseCRUD<TEntity, TKey> : IServiceBaseCRUD<TEntity, TKey> where TEntity : Entity<TEntity, TKey>
    {

        #region Properties
        
        private readonly IRepositoryBaseCRUD<TEntity, TKey> _repository;

        #endregion Properties

        #region Constructors
        public ServiceBaseCRUD(IRepositoryBaseCRUD<TEntity, TKey> repository)
        {
            _repository = repository;
        }
        #endregion Constructors

        #region Methods

        public virtual async Task<TEntity> AddAsync(TEntity obj)
        {
            await _repository.AddAsync(obj);
            return obj;
        }

        public virtual async Task<TEntity> FindByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            await _repository.UpdateAsync(obj);
        }

        public virtual async Task RemoveAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }
        #endregion Methods

    }
}
