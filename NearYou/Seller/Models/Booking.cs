namespace Seller.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Adress { get; set; }
        public string PhNo { get; set; }
        public int QuantityBooked { get; set; }
        public Decimal TotalPrice { get; set; }


    }
}
