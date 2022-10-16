using MagicAPI.Context;
using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public async Task<CardModel> UpdateAsync(CardModel model)
        {
            throw new System.NotImplementedException();
        }

        #endregion Methods

    }
}
