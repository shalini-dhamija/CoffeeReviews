using CoffeeReviews.Enums;
using CoffeeReviews.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace CoffeeReviews;

public class CoffeeContext : DbContext
{
    public DbSet<Variety> Varieties { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=coffee; Username=coffee; Password=coffee");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var geisha = new Variety
        {
            Id = -1,
            Slug = "geisha",
            Name = "Geisha",
            BeanType = BeanType.Arabica,
            RegionOfOrigin = "Ethiopia",
            Description = "Gesha coffee, sometimes referred to as Geisha coffee, is a variety of coffee tree that originated in the Gori Gesha forest, Ethiopia, though it is now grown in several other nations in Africa, Asia, and the Americas. It is widely known for its unique flavor profile of floral and sweet notes, its high selling price, and its exclusivity as its demand has increased over the years.",
        };

        modelBuilder.Entity<Variety>().HasData(geisha);
    }
}