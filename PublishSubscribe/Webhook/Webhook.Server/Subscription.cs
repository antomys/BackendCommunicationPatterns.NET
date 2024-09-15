namespace Webhook.Server;

public sealed record Subscription(string Topic, string Callback);
