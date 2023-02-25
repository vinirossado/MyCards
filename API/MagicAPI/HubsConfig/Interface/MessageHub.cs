using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicAPI.HubsConfig.Interface
{
    public class MessageHub : Hub<IMessageHubClient>
    {
        public static ConcurrentDictionary<string, List<string>> ConnectedUsers = new ConcurrentDictionary<string, List<string>>();
        public async Task SendOffersToUser(List<string> message)
        {
            await Clients.All.SendOffersToUser(message);
        }

        public override Task OnConnectedAsync()
        {
            Trace.TraceInformation("MapHub started. ID: {0}", Context.ConnectionId);

            var userName = "testUserName1"; // or get it from Context.User.Identity.Name;

            // Try to get a List of existing user connections from the cache
            List<string> existingUserConnectionIds;
            ConnectedUsers.TryGetValue(userName, out existingUserConnectionIds);

            // happens on the very first connection from the user
            if (existingUserConnectionIds == null)
            {
                existingUserConnectionIds = new List<string>();
            }

            // First add to a List of existing user connections (i.e. multiple web browser tabs)
            existingUserConnectionIds.Add(Context.ConnectionId);


            // Add to the global dictionary of connected users
            ConnectedUsers.TryAdd(userName, existingUserConnectionIds);

            return base.OnConnectedAsync();
        }

        public Task JoinRoom(string roomName)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        }

        public Task LeaveRoom(string roomName)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }

        //public override Task OnDisconnectedAsync(Exception exception)
        //{
        //    MyUserType garbage;

        //    MyUsers.TryRemove(Context.ConnectionId, out garbage);

        //    return base.OnDisconnectedAsync(exception);
        //}

        //public void PushData()
        //{
        //    //Values is copy-on-read but Clients.Clients expects IList, hence ToList()
        //    Clients.Clients(MyUsers.Keys.ToList()).ClientBoundEvent(data);
        //}


        public class MyUserType
        {
            public string ConnectionId { get; set; }
            // Can have whatever you want here
        }
    }
}
