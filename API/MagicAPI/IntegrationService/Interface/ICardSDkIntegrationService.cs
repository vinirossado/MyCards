using MagicAPI.Models;
using System.Threading.Tasks;

namespace MagicAPI.IntegrationService.Interface
{
    public interface ICardSDkIntegrationService
    {
        Task<CardModel> Find(CardModel card);
    }
}