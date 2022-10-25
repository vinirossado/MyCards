using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Interface
{
    public interface IDeckRepository
    {
        #region Methods
        Task<IEnumerable<DeckModel>> GetAllAsync();
        Task<DeckModel> GetAsync(int id);
        Task<DeckModel> CreateAsync(DeckModel model);
        Task<bool> CreateAsync(IList<DeckModel> model);

        Task<DeckModel> UpdateAsync(DeckModel model);
        Task<bool> DeleteAsync(DeckModel model);
        #endregion
    }
}
