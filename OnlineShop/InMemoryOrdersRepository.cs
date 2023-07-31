using OnlineShop.Models;

namespace OnlineShop
{
    public class InMemoryOrdersRepository : IOrdersRepository
    {
        private List<Cart> orders = new List<Cart>();
        public void Add(Cart cart)
        {
            orders.Add(cart);
        }
    }
}
