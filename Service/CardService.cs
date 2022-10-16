using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using System.Threading.Tasks;
using ICardService = MagicAPI.Service.Interface.ICardService;

namespace MagicAPI.Service
{
    public class CardService : ICardService
    {
        #region Properties
        private readonly IMTGSDkIntegrationService _mtgSDKIntegrationService;
        private readonly ICardRepository _cardRepository;
        #endregion Properties

        #region Constructors

        public CardService(IMTGSDkIntegrationService mtgSDKIntegrationService, ICardRepository cardRepository)
        {
            _mtgSDKIntegrationService = mtgSDKIntegrationService;
            _cardRepository = cardRepository;
        }

        #endregion Constructors

        #region Methods

        public async Task<CardModel> Register(string cardName, string setCollection)
        {
            var cardFounded = await _mtgSDKIntegrationService.Find(cardName, setCollection);
            await _cardRepository.CreateAsync(cardFounded);
            return cardFounded;

        }

        #endregion Methods

    }
}
