using MagicAPI.Context;
using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicAPI.Repository
{
    public class CardRepository : ICardRepository
    {

        #region Properties
        private readonly ApplicationDbContext _context;
        #endregion Properties

        #region Constructors

        public CardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Constructors


        #region Methods
        public async Task<CardModel> CreateAsync(CardModel model)
        {
            await _context.Card.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<bool> CreateAsync(IList<CardModel> model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DeckCardModel> CreateDeckCardAsync(DeckCardModel cards)
        {
            await _context.DeckCard.AddAsync(cards);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<bool> DeleteAsync(CardModel model)
        {
            throw new System.NotImplementedException();
        }

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
            return _context.Set<CardModel>().Where(c => EF.Functions.Like(c.Name, $"%{cardName}%")).FirstOrDefault();
        }

        public async Task<IList<CardModel>> GetCardsByDeckId(int deckId)
        {
            var deck = (from dc in _context.DeckCard
                        join c in _context.Card on dc.CardId equals c.Id
                        where dc.DeckId == deckId
                        select new CardModel(c.ImageUrl)).ToList();

            return deck;
        }

        public async Task<CardModel> UpdateAsync(CardModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<CardModel> UpdateAsync(IList<CardModel> model)
        {
            throw new System.NotImplementedException();
        }

        #endregion Methods

    }
}
