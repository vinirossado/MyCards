using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Repository
{
    public class DeckRepository : IDeckRepository
    {
        public async Task<DeckModel> CreateAsync(DeckModel model)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public async Task<DeckModel> UpdateAsync(DeckModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
