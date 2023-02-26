using MagicAPI.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MagicAPI.HubsConfig.Interface
{
    public partial class MessageHub : Hub<IMessageHubClient>, IBaseMessage
    {
        private IHubContext<MessageHub, IMessageHubClient> _messageHub;

        public MessageHub(IHubContext<MessageHub, IMessageHubClient> messageHub)
        {
            _messageHub = messageHub;
        }

        public static ConcurrentDictionary<string, List<string>> ConnectedUsers = new ConcurrentDictionary<string, List<string>>();
        public static IList<MessageHubModel> rooms = new List<MessageHubModel>();

        public override Task OnConnectedAsync()
        {
            Trace.TraceInformation("MapHub started. ID: {0}", Context.ConnectionId);

            rooms.Add(
                new MessageHubModel
                {
                    RoomId = Context.ConnectionId,
                    RoomName = Context.ConnectionId
                });

            var userName = Guid.NewGuid().ToString(); // or get it from Context.User.Identity.Name;

            // Try to get a List of existing user connections from the cache
            List<string> existingUserConnectionIds;
            ConnectedUsers.TryGetValue(userName, out existingUserConnectionIds);

            // happens on the very first connection from the user
            existingUserConnectionIds ??= new List<string>();

            // First add to a List of existing user connections (i.e. multiple web browser tabs)
            existingUserConnectionIds.Add(Context.ConnectionId);

            // Add to the global dictionary of connected users
            ConnectedUsers.TryAdd(userName, existingUserConnectionIds);

            return base.OnConnectedAsync();
        }
        //public async Task SendOffersToUser(List<string> message) => await Clients.All.SendOffersToUser(message);
        public async Task CreateRoom(string roomName)
        {
            await _messageHub.Clients.All.CreateRoom(roomName);
        }

        #region Useless

        //public async Task CreateRoom(string roomName) => myGroups.Add(roomName);
        //public async Task DeleteRoom(string roomName) => myGroups.Remove(roomName);
        //public async Task<bool> CheckIfRoomExists(string roomName) => true;
        //public Task LeaveRoom(string roomName) => Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        public async Task<IList<MessageHubModel>> GetAllRooms()
        {
            await _messageHub.Clients.All.GetAllRooms(rooms);
            return rooms;
        }
        //public async Task JoinRoom(string roomName)
        //{
        //    if (await CheckIfRoomExists(roomName))
        //    {
        //        await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        //        await Clients.Group(roomName).SendOffersToUser(new List<string>());
        //    }
        //    else
        //    {
        //        throw new Exception("The room does not exists!");
        //    }
        //    await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        //    Clients.Group(roomName);

        //}
        #endregion Useless

    }
}
