using MagicAPI.Application.Base.Interface;
using MagicAPI.Dto;
using MagicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Application.Interface
{
    public interface IDeckApplication : IApplicationBaseCRUD<DeckModel, int>
    {
        Task<DeckDto> GetAsync(int id);
        Task<int> CreateDeckAsync(DeckDto dto);

    }
}
