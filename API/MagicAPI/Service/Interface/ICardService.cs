using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service.Interface
{
    public interface ICardService
    {
        Task<IEnumerable<CardModel>> GetAllAsync();
        Task<CardModel> GetAsync(int id);
        Task<CardModel> GetByNameAsync(string cardName);
        Task<IEnumerable<CardModel>> GetCardsByDeckIdAsync(int deckId);

        Task<CardModel> CreateAsync(CardModel model);
        Task<bool> CreateAsync(IList<CardModel> model);
        Task<CardModel> UpdateAsync(CardModel model);
        Task<CardModel> UpdateAsync(IList<CardModel> model);
        Task<bool> DeleteAsync(CardModel model);
    }
}
