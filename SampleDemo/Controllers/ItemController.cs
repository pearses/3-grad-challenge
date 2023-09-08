// SoftwareEngineeringChallenge/Controllers/ItemController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly AppDbContext _context;

    public ItemController(AppDbContext context)
    {
        _context = context;
    }

    // Implement your API endpoints (GET, POST, PUT, DELETE) here
}
