using MagicAPI.Models;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.HubsConfig.Interface
{
    public interface IBaseMessage
    {
        Task CreateRoom(string roomName);
        //Task JoinRoom(string roomName);
        Task<IList<MessageHubModel>> GetAllRooms();

    }
}
