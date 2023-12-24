using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        //[StringLength(100,MinimumLength =20)]Hem veri tabanı etkisi hem de validation etkisi
        public string Name { get; set; }
        [Precision(9, 2)]
        public decimal Price { get; set; }
        [Precision(9, 2)]
        public decimal DiscountPrice { get; set; }
        public int Stock { get; set; }

    }
}
