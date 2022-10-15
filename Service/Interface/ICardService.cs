using MagicAPI.Models;
using System.Threading.Tasks;

namespace MagicAPI.Service.Interface
{
    public interface ICardService
    {
        Task<CardModel> Find(string cardName, string setCollection);
    }
}
