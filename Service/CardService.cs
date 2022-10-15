using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using ICardService = MagicAPI.Service.Interface.ICardService;

namespace MagicAPI.Service
{
    public class CardService : ICardService
    {
        #region Properties
        private readonly IMTGSDkIntegrationService _mtgSDKIntegrationService;
        #endregion Properties

        #region Constructors

        public CardService(IMTGSDkIntegrationService mtgSDKIntegrationService)
        {
            _mtgSDKIntegrationService = mtgSDKIntegrationService;
        }

        #endregion Constructors

        #region Methods

        public async Task<CardModel> Find(string cardName, string setCollection)
        {
            return await _mtgSDKIntegrationService.Find(cardName, setCollection);
        }

        #endregion Methods


    }
}
