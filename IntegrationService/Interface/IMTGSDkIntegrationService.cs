using MagicAPI.Models;
using System.Threading.Tasks;

namespace MagicAPI.IntegrationService.Interface
{
    public interface IMTGSDkIntegrationService
    {
        Task<CardModel> Find(CardModel card);

    }
}
