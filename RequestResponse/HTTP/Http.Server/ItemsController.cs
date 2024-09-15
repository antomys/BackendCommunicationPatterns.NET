using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HTTP.Server;

[ApiController]
[Route("[controller]")]
public sealed class ItemsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateItem(Item item)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateItem(int id, Item item)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetItem(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteItem(int id)
    {
        return Ok();
    }

    [HttpPatch("{id}")]
    public IActionResult PatchItem(JsonPatchDocument<Item> patchDoc)
    {
        return Ok();
    }
}
