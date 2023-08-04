namespace OnlineShop.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public Cart Cart { get; set; }
    }
}
