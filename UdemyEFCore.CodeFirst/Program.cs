using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Initializer.Build();
using (var _context = new AppDbContext())
{

    var category = await _context.Categories.FirstAsync();

    Console.WriteLine("Category çekildi");
    var products = category.Products;


    Console.WriteLine("işlem bitti");
}
