using MagicAPI.Models;
using System.Threading.Tasks;

namespace MagicAPI.Service.Interface
{
    public interface ICardService
    {
        Task<CardModel> Register(string cardName, string setCollection);
    }
}
