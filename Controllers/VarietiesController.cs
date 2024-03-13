using Microsoft.AspNetCore.Mvc;

namespace CoffeeReviews.Controllers;

[ApiController]
[Route("varieties")]
public class VarietiesController : Controller
{
    private readonly CoffeeContext _context;

    public VarietiesController(CoffeeContext context)
    {
        _context = context;
    }

    [HttpGet("")]
    public IActionResult GetAll()
    {
        return Ok(_context.Varieties.ToList());
    }

    [HttpGet("{slug}")]
    public IActionResult GetBySlug(string slug)
    {
        try 
        {
            return Ok(_context.Varieties.Single(variety => variety.Slug == slug));
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }
}