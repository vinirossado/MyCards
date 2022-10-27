using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Interface
{
    public interface IDeckRepository
    {
        #region Methods
        Task<IEnumerable<DeckCardModel>> GetAllAsync();
        Task<DeckCardModel> GetAsync(int id);
        Task<DeckCardModel> CreateAsync(DeckCardModel model);
        Task<bool> CreateAsync(IList<DeckCardModel> model);

        Task<DeckCardModel> UpdateAsync(DeckCardModel model);
        Task<bool> DeleteAsync(DeckCardModel model);
        #endregion
    }
}
