namespace Seller.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
