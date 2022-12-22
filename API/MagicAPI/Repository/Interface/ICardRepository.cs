﻿using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository.Interface
{
    public interface ICardRepository
    {
        #region Methods
        Task<IEnumerable<CardModel>> GetAllAsync();
        Task<CardModel> GetAsync(int id);
        Task<CardModel> GetByNameAsync(string cardName);
        Task<CardModel> CreateAsync(CardModel model);
        Task<IList<CardModel>> GetCardsByDeckId(int deckId);

        Task<DeckCardModel> CreateDeckCardAsync(DeckCardModel model);
        Task<bool> CreateAsync(IList<CardModel> model);
        Task<CardModel> UpdateAsync(CardModel model);
        Task<CardModel> UpdateAsync(IList<CardModel> model);
        Task<bool> DeleteAsync(CardModel model);
        #endregion
    }
}