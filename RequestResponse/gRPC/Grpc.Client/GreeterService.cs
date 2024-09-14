using Grpc.Server;

namespace Grpc.Client;

public sealed class GreeterService(Greeter.GreeterClient client)
{
    public async Task<string> SayHelloAsync(string name)
    {
        var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        return reply.Message;
    }
}
