using MassTransit;
using MessageBroker.Contracts;

namespace MessageBroker.Consumer;

/// <inheritdoc />
public sealed record ItemCreatedMessageConsumer : IConsumer<ItemCreatedMessage>
{
    /// <inheritdoc />
    public Task Consume(ConsumeContext<ItemCreatedMessage> context)
    {
        Console.WriteLine(
            $"Item '{context.Message.Name}' " +
            $"with price '{context.Message.Price}' created.");

        return Task.CompletedTask;
    }
}
