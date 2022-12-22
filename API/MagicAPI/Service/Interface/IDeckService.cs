using MagicAPI.Dto;
using MagicAPI.Models;
using MagicAPI.Service.Base.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service.Interface
{
    public interface IDeckService : IServiceBaseCRUD<DeckModel, int>
    {
        Task<DeckModel> GetAsync(int id);
        Task<int> CreateDeckAsync(DeckModel model);

    }
}
