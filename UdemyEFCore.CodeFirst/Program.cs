using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Initializer.Build();
using (var _context = new AppDbContext())
{
    var category = new Category() { Name = "kalemler" };
    category.Products.Add(new Product()
    {
        Name = "kalem1",
        Price = 10,
        Stock = 100,
        Barcode = 123,
        ProductFeature = new ProductFeature() { Color = "Red", Height = 100, Width = 100 }
    });
    category.Products.Add(new Product()
    {
        Name = "kalem2",
        Price = 10,
        Stock = 100,
        Barcode = 123,
        ProductFeature = new ProductFeature() { Color = "Blue", Height = 100, Width = 100 }
    });
    category.Products.Add(new Product()
    {
        Name = "kalem3",
        Price = 10,
        Stock = 100,
        Barcode = 123,
        ProductFeature = new ProductFeature() { Color = "Black", Height = 100, Width = 100 }
    });

    _context.Categories.Add(category);
    _context.SaveChanges();
    Console.WriteLine("işlem bitti");
}
