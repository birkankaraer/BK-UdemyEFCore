using Microsoft.EntityFrameworkCore;
using UdeymEFCore.DatabaseFirstByScaffold.Models;

using (var context = new UdemyEfcoreDatabaseFirstDbContext())
{
    var produtcs = await context.Products.ToListAsync();

    produtcs.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock}");
        //{p.Stock.hasvalue} kodu ile değerin null olup olmadığını kontrol edebiliriz
    });
}
