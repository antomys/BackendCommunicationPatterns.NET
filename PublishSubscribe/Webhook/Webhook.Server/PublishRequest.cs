namespace Webhook.Server;

public sealed record PublishRequest(string Topic, object Message);
