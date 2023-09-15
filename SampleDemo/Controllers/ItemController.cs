using Microsoft.AspNetCore.Mvc;
using System;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly AppDbContext _context;

    public ItemController(AppDbContext context)
    {
        _context = context;
    }

    // POST /api/item
    [HttpPost]
    public IActionResult CreateItem([FromBody] Item item)
    {
        // Create item logic
        return Ok(item); // Return the created item
    }

    // GET /api/item/{id}
    [HttpGet("{id}")]
    public IActionResult GetItem(int id)
    {
        var item = _context.Items.Find(id);

        if (item == null)
        {
            return NotFound(); // Return a 404 response if item is not found
        }

        return Ok(item); // Return the retrieved item
    }

    // PUT /api/item/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateItem(int id, [FromBody] Item item)
    {
        // Update item by id logic
        return Ok(item); // Return the updated item
    }

    // DELETE /api/item/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteItem(int id)
    {
        // Delete item by id logic
        return Ok("Item deleted successfully");
    }
}
