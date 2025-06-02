using SmartCart.Models;

public class CategoryWithProductImage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ProductImage { get; set; }
}

public class HomeViewModel
{
    public List<Product> FeaturedProducts { get; set; }
    public List<CategoryWithProductImage> MonthlyCategories { get; set; }
}