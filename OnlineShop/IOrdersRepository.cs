using OnlineShop.Models;

namespace OnlineShop
{
    public interface IOrdersRepository
    {
        void Add(Order order);
    }
}