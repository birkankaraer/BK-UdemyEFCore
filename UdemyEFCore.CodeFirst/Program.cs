using AutoMapper.Internal.Mappers;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;
using UdemyEFCore.CodeFirst.DTOs;
using UdemyEFCore.CodeFirst.Mappers;

Initializer.Build();
using (var _context = new AppDbContext())
{
    //eğer bu transaction yapısını loglama yapmayacaksak, try catch içerisine almamıza gerek yok. Çünkü zaten transaction içerisinde hata olursa, transaction içerisindeki tüm işlemler geri alınır. 
    using (var transaction = _context.Database.BeginTransaction())
    {
        var category = new Category() { Name = "Arabalar" };
        _context.Categories.Add(category);
        _context.SaveChanges();

        //eğer burada iki işlemden biri hata verirse diğeri de çalışmayacak. Çünkü ikisi de aynı transaction içerisinde çalışıyor.

        var product = new Product()
        {
            Name = "BMW",
            Price = 100000,
            Stock = 5,
            Barcode = 123,
            Category = category
        };

        _context.Products.Add(product);
        _context.SaveChanges();
        transaction.Commit();
    }

    //#region
    //var category = new Category() { Name = "Telefonlar" };
    //category.Products.Add(new()
    //{
    //    Name = "telefon1",
    //    Price = 10,
    //    Stock = 5,
    //    Barcode = 123,
    //    ProductFeature = new ProductFeature()
    //    {
    //        Color = "Black",
    //        Height = 100,
    //        Width = 50
    //    }
    //});
    //category.Products.Add(new()
    //{
    //    Name = "telefon2",
    //    Price = 10,
    //    Stock = 5,
    //    Barcode = 123,
    //    ProductFeature = new ProductFeature()
    //    {
    //        Color = "Black",
    //        Height = 100,
    //        Width = 50
    //    }
    //});
    //category.Products.Add(new()
    //{
    //    Name = "telefon3",
    //    Price = 10,
    //    Stock = 5,
    //    Barcode = 123,
    //    ProductFeature = new ProductFeature()
    //    {
    //        Color = "Black",
    //        Height = 100,
    //        Width = 50
    //    }
    //});
    //category.Products.Add(new()
    //{
    //    Name = "telefon4",
    //    Price = 10,
    //    Stock = 5,
    //    Barcode = 123,
    //});
    //_context.Categories.Add(category);
    //_context.SaveChanges();
    //#endregion
}

string FormatPhone(string phone)
{
    return phone.Substring(1, phone.Length - 1);
}
