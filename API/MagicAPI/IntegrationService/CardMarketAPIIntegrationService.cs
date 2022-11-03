using System.Threading.Tasks;
using MagicAPI.IntegrationService.Interface;
using MagicAPI.Models;

namespace MagicAPI.IntegrationService
{
    public class CardMarketAPIIntegrationService : ICardSDkIntegrationService
    {
        public Task<CardModel> Find(CardModel card)
        {
            throw new System.NotImplementedException();
        }
    }
}
