using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyEFCore.CodeFirst.DAL;
using UdemyEFCore.CodeFirst.DTOs;

namespace UdemyEFCore.CodeFirst.Mappers
{
    //bu bir mvc veya api projesi olmadığı için bu classı oluşturduk,orada direk olarak startup.cs içerisinde oluşturuyoruz.
    //orada direk olarak şöyle bir kod yazılıyor: builder.services.AddAutoMapper(typeof(Startup));
    //ben burada objectmapper yüklenme işlemini lazy loading ile yapacağım. Çünkü bu classı kullanmadığım zaman mapper yüklenmesin.
    internal class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomMapping>();
            });
            return config.CreateMapper();
        });

        public static IMapper Mapper => lazy.Value;
    }
    //uygulama ayağa kalktığı zaman burası çalışmayacak ama ne zaman ki objectmapper üzerinden mapper çağırılırsa o zaman çalışacak.
    //Yani lazy daha sonra çalışacak. Static olan tipler uygulama ayağa kalktığı zaman çalışır. Ama bizim burada lazy ile çalışmasını istiyoruz. Ne zaman value çağırılırsa o zaman çalışsın.

    internal class CustomMapping:Profile
    {
        public CustomMapping()
        {
            CreateMap<ProductDto, Product>().ReverseMap();//ReverseMap() ile çift yönlü map işlemi yapabiliriz.
        }
    }
}
