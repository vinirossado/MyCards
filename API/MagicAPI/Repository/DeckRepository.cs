using MagicAPI.Context;
using MagicAPI.Dto;
using MagicAPI.Models;
using MagicAPI.Repository.Base;
using MagicAPI.Repository.Base.Interface;
using MagicAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using MtgApiManager.Lib.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicAPI.Repository
{
    public class DeckRepository : RepositoryBaseCRUD<DeckModel, int>, IDeckRepository
    {

        #region Properties
        private readonly ApplicationDbContext _context;
        #endregion Properties

        #region Constructors

        public DeckRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        #endregion Constructors

        #region Methods

        public async Task<int> CreateAsync(DeckModel model)
        {
            await _context.Deck.AddAsync(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }

        public async Task<bool> CreateAsync(IList<DeckModel> model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteAsync(DeckModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DeckModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<DeckModel> GetAsync(int id)
        {

            var deck = _context.Deck.FirstOrDefault();

            //var deck = (from dc in _context.DeckCard
            //            join c in _context.Card on dc.CardId equals c.Id
            //            join d in _context.Deck on dc.DeckId equals d.Id
            //            where dc.DeckId == id
            //            select new DeckModel
            //            {
            //                Name = d.Name,
            //                Price = d.Price,
            //                PowerLevel = d.PowerLevel,
            //                Guild = d.Guild,

            //            }).ToList();

            return deck;
        }

        public async Task<DeckModel> UpdateAsync(DeckModel model)
        {
            throw new System.NotImplementedException();
        }

        #endregion Methods

    }
}
