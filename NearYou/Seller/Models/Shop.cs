namespace Seller.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public int sellerId {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhNo { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }

    }
}
