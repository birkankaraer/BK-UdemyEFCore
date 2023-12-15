using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Initializer.Build();
using (var _context = new AppDbContext())
{



    //var product = await _context.Products.AsNoTracking().FirstAsync(x=> x.Id == 10);
    //var products = _context.Products.ToList();

    //products.ForEach(p =>
    //{
    //    p.Stock += 100;

    //});
    //_context.ChangeTracker.Entries().ToList().ForEach(e =>
    //{
    //    if (e.Entity is Product p)
    //    {
    //        Console.WriteLine(e.State);
    //    }
    //});

    //_context.SaveChanges();

    //_context.Products.Add(new() { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });
    //_context.Products.Add(new() { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });
    //_context.Products.Add(new() { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });

    //Console.WriteLine($"Context Id: {_context.ContextId}");

    //_context.SaveChanges();

    //var products = await _context.Products.ToListAsync();

    //products.ForEach(p =>
    //{
    //    p.Stock += 100;
    //});

    //_context.Update(new Product() { Id = 2, Name = "kalem", Price = 35, Stock = 15, Barcode = 123 });

    //var product  = await _context.Products.FirstAsync();//db de products tablosundaki ilk karşılaştığı datayı bulur. 

    //Console.WriteLine($"ilk state:{_context.Entry(product).State}");

    //_context.Entry(product).State = EntityState.Detached;

    //Console.WriteLine($"son state:{_context.Entry(product).State}");

    //product.Name = "kalemlik";
    //bu iki işlem aynı görevi görüyor
    //_context.Entry(product).State = EntityState.Deleted;

    //await _context.SaveChangesAsync();
    //Console.WriteLine($"state after save change:{_context.Entry(product).State}");

    //await _context.AddAsync(newProduct);
    //bu iki işlem aynı
    //_context.Entry(newProduct).State = EntityState.Added;



    //var produtcs = await _context.Products.ToListAsync();

    //produtcs.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;
    //    //Veri tabanında ilk defa veri çekildiği anda efcore'un vermiş olduğu state(unchanged)
    //    Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock} state : {state}");
    //    //{p.Stock.hasvalue} kodu ile değerin null olup olmadığını kontrol edebiliriz
    //});


}
