namespace ShoesProject.Models;

public partial class Subcategory
{
    public int Id { get; set; }

    public string SubcategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
