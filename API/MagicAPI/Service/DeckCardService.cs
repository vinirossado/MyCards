using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using MagicAPI.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service
{
    public class DeckCardService : IDeckCardService
    {
        private readonly IDeckCardRepository _deckCardRepository;
        #region Properties

        #endregion Properties

        #region Constructors
        public DeckCardService(IDeckCardRepository deckCardRepository)
        {
            _deckCardRepository = deckCardRepository;
        }
        #endregion Constructors

        #region Methods

        public async Task<DeckCardModel> CreateDeckCardAsync(IEnumerable<DeckCardModel> model)
        {
            return await _deckCardRepository.CreateDeckCardAsync(model);
        }
        #endregion Methods
    }
}
