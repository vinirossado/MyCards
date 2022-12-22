using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service.Interface
{
    public interface IDeckCardService
    {
        Task<DeckCardModel> CreateDeckCardAsync(IEnumerable<DeckCardModel> model);

    }
}
