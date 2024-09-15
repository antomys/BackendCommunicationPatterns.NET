using WebSocket.Server;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ChatService>();
var app = builder.Build();
app.UseWebSockets();

app.MapGet("/", async (HttpContext context, ChatService chatService) =>
{
    if (context.WebSockets.IsWebSocketRequest)
    {
        var webSocket = await context.WebSockets.AcceptWebSocketAsync();
        await chatService.HandleWebSocketConnection(webSocket);
    }
    else
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync("Expected a WebSocket request");
    }
});

app.Run();
