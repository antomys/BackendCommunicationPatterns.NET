using Microsoft.AspNetCore.SignalR;

namespace SignalR.Server;

public sealed class SimpleChatHub : Hub
{
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}
