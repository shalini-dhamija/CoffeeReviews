using CoffeeReviews.Enums;
using CoffeeReviews.Models.Data;
using CoffeeReviews.Models.Request;
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

    [HttpPost("")]
    public IActionResult Add([FromBody] AddVarietyRequest addVarietyRequest)
    {
        var newVariety = new Variety
        {
            Slug = addVarietyRequest.Name.ToLower().Replace(' ', '-'),
            Name = addVarietyRequest.Name,
            BeanType = Enum.Parse<BeanType>(addVarietyRequest.BeanType),
            RegionOfOrigin = addVarietyRequest.RegionOfOrigin,
            Description = addVarietyRequest.Description
        };
        var addedVariety = _context.Varieties.Add(newVariety).Entity;
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetBySlug), new {Slug = addedVariety.Slug}, addedVariety);
    }
}