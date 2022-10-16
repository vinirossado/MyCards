using AutoMapper;
using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;
using MtgApiManager.Lib.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicAPI.IntegrationService
{
    public class MTGSDkIntegrationService : IMTGSDkIntegrationService
    {
        #region Properties
        private readonly IMtgServiceProvider _mtgServiceProvider;
        private readonly ICardService _service;
        private readonly IMapper _mapper;
        #endregion Properties

        #region Constructors

        public MTGSDkIntegrationService(IMtgServiceProvider mtgServiceProvider, IMapper mapper)
        {
            _mtgServiceProvider = mtgServiceProvider;

            _service = _mtgServiceProvider.GetCardService();

            _mapper = mapper;

        }

        #endregion Constructors

        #region Methods

        public async Task<CardModel> Find(string cardName, string setCollection)
        {
            var result = await _service.Where(x => x.Name, cardName)
                                      .AllAsync();

            if (!result.Value.Any())
                return null;

            var cardWithImages = result.Value.Where(x => x.ImageUrl != null).ToList();
            var cards = new List<CardModel>();
            cards.AddRange(_mapper.Map<List<CardModel>>(cardWithImages));

            return cards[0];
        }

        #endregion Methods
    }
}
