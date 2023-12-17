using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Initializer.Build();
using (var _context = new AppDbContext())
{
    _context.Products.Add(new Product { Name ="kalem1",Price=200,Stock=1,Barcode=123,Kdv=18});
    _context.SaveChanges();
    Console.WriteLine("işlem bitti");
}
