using System.ComponentModel.DataAnnotations;

namespace Concurrency.WebMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        
        //[Timestamp] bu attribute ile rowversion alanı oluşturulur. bu birinci yöntemdir.
        public byte[] RowVersion { get; set; }
    }
}
