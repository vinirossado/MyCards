﻿using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MagicAPI.Repository;

namespace MagicAPI.Service
{
    public class CardService
    {
        #region Properties
        private readonly CardRepository _cardRepository;
        #endregion Properties

        #region Constructors

        public CardService(CardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        #endregion Constructors

        #region Methods

        //public async async Task<CardModel> RegisterAsync(string cardName, string setCollection)
        //{
        //    var cardFounded = await _mtgSDKIntegrationService.Find(cardName, setCollection);
        //    await _cardRepository.CreateAsync(cardFounded);
        //    return cardFounded;

        //}

        //public async async Task<CardModel> FindAsync(string cardName)
        //{
        //    CardModel cardDb = await _cardRepository.FindAsync(cardName);
        //}

        public async Task<IEnumerable<CardModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<CardModel> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CardModel> GetByNameAsync(string cardName)
        {
            return await _cardRepository.GetByNameAsync(cardName);
        }

        public async Task<CardModel> CreateAsync(CardModel model)
        {
            //var cardFounded = await _mtgSDKIntegrationService.Find(model);
            //await _cardRepository.CreateAsync(model);
            var deckCardModel = new DeckCardModel(1, model.Id);
            await _cardRepository.CreateDeckCardAsync(deckCardModel);

            return model;
        }

        public async Task<bool> CreateAsync(IList<CardModel> model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CardModel> UpdateAsync(CardModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CardModel> UpdateAsync(IList<CardModel> model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteAsync(CardModel model)
        {
            throw new System.NotImplementedException();
        }

        #endregion Methods

    }
}
