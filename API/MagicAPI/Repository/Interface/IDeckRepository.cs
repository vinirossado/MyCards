using MagicAPI.Dto;
using MagicAPI.Models;
using MagicAPI.Repository.Base.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Interface
{
    public interface IDeckRepository : IRepositoryBaseCRUD<DeckModel, int>
    {
        #region Methods
        Task<IEnumerable<DeckModel>> GetAllAsync();
        Task<DeckModel> GetAsync(int id);
        Task<int> CreateAsync(DeckModel model);
        Task<bool> CreateAsync(IList<DeckModel> model);

        Task<DeckModel> UpdateAsync(DeckModel model);
        Task<bool> DeleteAsync(DeckModel model);
        #endregion
    }
}
