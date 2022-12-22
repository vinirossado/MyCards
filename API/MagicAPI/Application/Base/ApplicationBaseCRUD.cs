using MagicAPI.Application.Base.Interface;
using MagicAPI.Models;
using MagicAPI.Models.Interface;
using MagicAPI.Service.Base.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Application.Base
{
    public class ApplicationBaseCRUD<TEntity, TKey> : IApplicationBaseCRUD<TEntity, TKey> where TEntity : Entity<TEntity, TKey>
    {
        #region Properties

        private readonly IServiceBaseCRUD<TEntity, TKey> _service;
        private readonly IUnitOfWork _uow;

        #endregion Properties

        #region Construtors

        public ApplicationBaseCRUD(IServiceBaseCRUD<TEntity, TKey> service, IUnitOfWork uow)
        {
            _service = service;
            _uow = uow;
        }

        #endregion Construtors

        #region Methods

        public virtual bool Save() => _uow.Save();

        public virtual async Task<TEntity> AddAsync(TEntity obj)
        {
            await _service.AddAsync(obj);
            _uow.Save();
            return obj;
        }

        public virtual async Task<TEntity> FindByIdAsync(int id)
        {
            return await _service.FindByIdAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            await _service.UpdateAsync(obj);
            _uow.Save();
        }

        public virtual async Task RemoveAsync(int id)
        {
            await _service.RemoveAsync(id);
            _uow.Save();
        }

        #endregion Methods

    }
}
