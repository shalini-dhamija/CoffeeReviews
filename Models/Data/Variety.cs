using CoffeeReviews.Enums;

namespace CoffeeReviews.Models.Data;

public class Variety 
{   
    public int Id { get; set; }
    public required string Name { get; set; }
    public required BeanType BeanType { get; set; }
    public required string RegionOfOrigin { get; set; }
    public required string Description { get; set; }
}
