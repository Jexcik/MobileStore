namespace OnlineShop.Models
{
    public class Cart
    {
        public Guid Id { get; }
        public string UserId { get; }

        public List<CartItem> Items { get; set; }

        public decimal Cost
        {
            get
            {
                return Items.Sum(x => x.Cost);
            }
        }
    }
}
