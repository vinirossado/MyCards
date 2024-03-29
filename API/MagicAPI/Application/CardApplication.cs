﻿using MagicAPI.Application.Interface;
using MagicAPI.IntegrationService;
using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;
using MagicAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Application
{
    public class CardApplication : ICardApplication
    {

        #region Properties
        private readonly ICardService _cardService;
        private readonly IMTGSDkIntegrationService _mtgSDKIntegrationService;

        #endregion Properties

        #region Constructors
        public CardApplication(ICardService cardService, IMTGSDkIntegrationService mtgSDKIntegrationService)
        {
            _cardService = cardService;
            _mtgSDKIntegrationService = mtgSDKIntegrationService;

        }
        #endregion Constructors

        #region Methods
        public async Task<CardModel> CreateAsync(CardModel model)
        {
            CardModel cardDb = await _cardService.GetByNameAsync(model.Name);

            if (cardDb is null)
                cardDb = await _mtgSDKIntegrationService.Find(model);

            //if (cardDb is null)
            //    throw new Exception($"The card ${model.Name} is already registered.");

            //return _cardService.RegisterAsync(cardName, setCollection);
            return cardDb;
        }

        public async Task<bool> CreateAsync(IList<CardModel> model)
        {
            //var cardDb = _cardService.Get(cardName);
            //if (cardDb != null)
            //    throw new Exception($"The card ${cardName} is already registered.");

            //return _cardService.RegisterAsync(cardName, setCollection);
            return true;
        }

        public async Task<bool> DeleteAsync(CardModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CardModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CardModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CardModel> GetByNameAsync(string cardName)
        {
            throw new NotImplementedException();
        }

        //public async Task<CardModel> Register(string cardName, string setCollection)
        //{
        //    var cardDb = _cardService.FindAsync(cardName);
        //    if (cardDb != null)
        //        throw new Exception($"The card ${cardName} is already registered.");

        //    return _cardService.RegisterAsync(cardName, setCollection);


        //}

        public async Task<CardModel> UpdateAsync(CardModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<CardModel> UpdateAsync(IList<CardModel> model)
        {
            throw new NotImplementedException();
        }
        #endregion Methods
    }
}
