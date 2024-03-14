using CoffeeReviews.Enums;

namespace CoffeeReviews.Models.Request;

public class AddVarietyRequest
{
    public required string Name {get; set;}
    public required string BeanType {get;set;}
    public required string RegionOfOrigin {get; set;}
    public required string Description {get;set;}
}