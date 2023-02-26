using MagicAPI.Models;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.HubsConfig.Interface
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser(List<string> message);
        Task CreateRoom(string roomName);
        Task GetAllRooms(IList<MessageHubModel> rooms);
        //Task DeleteRoom(string roomName);
        //Task<bool> CheckIfRoomExists(string roomName);
    }
}
