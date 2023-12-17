using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }
        //[StringLength(100,MinimumLength =20)]Hem veri tabanı etkisi hem de validation etkisi
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Kdv { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal PriceKdv { get; set; }

    }
}
