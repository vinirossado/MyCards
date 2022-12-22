using MagicAPI.Context;
using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository
{
    public class DeckCardRepository : IDeckCardRepository
    {
        #region Properties
        private readonly ApplicationDbContext _context;
        #endregion Properties

        #region Constructors
        public DeckCardRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion Constructors
        public async Task<DeckCardModel> CreateDeckCardAsync(IEnumerable<DeckCardModel> model)
        {
            await _context.DeckCard.AddRangeAsync(model);
            await _context.SaveChangesAsync();
            return null;
        }

    }
}
