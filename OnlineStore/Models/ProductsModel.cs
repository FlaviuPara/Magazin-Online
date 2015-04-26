using System.Data.Entity;

namespace OnlineStore.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int quantity { get; set; }
    }

}