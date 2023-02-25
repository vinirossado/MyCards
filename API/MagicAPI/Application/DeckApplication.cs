using AutoMapper;
using MagicAPI.Application.Base;
using MagicAPI.Application.Interface;
using MagicAPI.Dto;
using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;
using MagicAPI.Models.Interface;
using MagicAPI.Request;
using MagicAPI.Service;
using MagicAPI.Service.Interface;
using MtgApiManager.Lib.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicAPI.Application
{
    public class DeckApplication : ApplicationBaseCRUD<DeckModel, int>, IDeckApplication
    {

        #region Properties

        private readonly IDeckService _deckService;
        private readonly IDeckCardService _deckCardService;
        private readonly MagicAPI.Service.Interface.ICardService _cardService;
        private readonly IMTGSDkIntegrationService _mtgSDKIntegrationService;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;


        #endregion Properties

        #region Constructors
        public DeckApplication(IDeckService deckService, IMTGSDkIntegrationService mtgSDKIntegrationService, IDeckCardService deckCardService, IUnitOfWork uow, IMapper mapper, Service.Interface.ICardService cardService) : base(deckService, uow)
        {
            _deckService = deckService;
            _mtgSDKIntegrationService = mtgSDKIntegrationService;
            _deckCardService = deckCardService;
            _uow = uow;
            _mapper = mapper;
            _cardService = cardService;
        }

        #endregion Constructors

        #region Methods

        public Task<DeckModel> AddAsync(DeckModel obj)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> CreateDeckAsync(DeckDto dto)
        {
            var createdDeckId = await _deckService.CreateDeckAsync(new DeckModel(dto.Name, dto.Price, dto.PowerLevel, dto.Guild));

            var cardsToAdd = new List<DeckCardModel>();

            if (!dto.Cards.Any())
                return 2;

            //var listCardsMapped = _mapper.Map<IEnumerable<DeckCardModel>>(dto.Cards);

            foreach (var card in dto.Cards)
            {
                var cardDb = await _cardService.GetByNameAsync(card.CardName);
                cardsToAdd.Add(new DeckCardModel(createdDeckId, cardDb.Id));
            }

            await _deckCardService.CreateDeckCardAsync(cardsToAdd);

            return 1;/*_deckCardService.CreateDeckCardAsync();*/
        }


        public Task<IEnumerable<DeckModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }


        public async Task<DeckDto> GetAsync(int id)
        {
            var deckDb = await _deckService.GetAsync(id);
            var deckMapped = _mapper.Map<DeckDto>(deckDb);

            var cardsDeck = await _cardService.GetCardsByDeckIdAsync(deckDb.Id);
            deckMapped.CardsUrl = cardsDeck.Select(x => x.ImageUrl).ToList();

            return deckMapped;
        }

        public Task RemoveAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(DeckModel obj)
        {
            throw new System.NotImplementedException();
        }

        #endregion Methods

    }
}
