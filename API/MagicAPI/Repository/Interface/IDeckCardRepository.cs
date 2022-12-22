using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Interface
{
    public interface IDeckCardRepository
    {
        Task<DeckCardModel> CreateDeckCardAsync(IEnumerable<DeckCardModel> model);

    }
}
