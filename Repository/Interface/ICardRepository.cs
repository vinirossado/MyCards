using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Interface
{
    public interface ICardRepository
    {
        #region Methods
        Task<IEnumerable<CardModel>> GetAllAsync();
        Task<CardModel> GetAsync(int id);
        Task<CardModel> CreateAsync(CardModel model);
        Task<bool> CreateAsync(IList<CardModel> model);
        Task<CardModel> UpdateAsync(CardModel model);
        Task<bool> DeleteAsync(CardModel model);
        #endregion
    }
}
