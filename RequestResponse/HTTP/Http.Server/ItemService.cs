namespace HTTP.Server;

public sealed class ItemService
{
    public async Task<Item> GetItem(int id)
    {
        return await Task.FromResult(Item.Default);
    }
}
