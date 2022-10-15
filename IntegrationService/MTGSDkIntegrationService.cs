using AutoMapper;
using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;
using MtgApiManager.Lib.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.IntegrationService
{
    public class MTGSDkIntegrationService : IMTGSDkIntegrationService
    {
        #region Properties
        private readonly IMtgServiceProvider _mtgServiceProvider;
        private readonly ICardService _service;
        #endregion Properties

        #region Constructors

        public MTGSDkIntegrationService(IMtgServiceProvider mtgServiceProvider)
        {
            _mtgServiceProvider = mtgServiceProvider;

            _service = _mtgServiceProvider.GetCardService();

        }

        #endregion Constructors

        #region Methods

        public async Task<CardModel> Find(string cardName, string setCollection)
        {
            var result = await _service.Where(x => x.Name, cardName)
                                      .AllAsync();

            var cards = new List<CardModel>();
            cards.AddRange(Mapper.Map<List<CardModel>>(result.Value));

            return cards[0];
        }

        #endregion Methods
    }
}
