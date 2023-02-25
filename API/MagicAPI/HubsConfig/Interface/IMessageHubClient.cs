using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.HubsConfig.Interface
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser(List<string> message);
    }
}
