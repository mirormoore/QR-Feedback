using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Miro.WebSockets.Hubs
{
    public class MiroHub : Hub
    {

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }

        public bool BoardConnected(string connectionID)
        {

            if (ConnectedUser.Ids.Contains(connectionID))
            {
                return true;
            }

            return false;

        }

        public async Task SendSticky(string json, string connection)
        {

            await Clients.Client(connection).SendAsync("StickyMessage", json);
        }

        public override Task OnConnectedAsync()
        {
            ConnectedUser.Ids.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            ConnectedUser.Ids.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

    }

    public static class ConnectedUser
    {
        public static List<string> Ids = new List<string>();
    }
}
