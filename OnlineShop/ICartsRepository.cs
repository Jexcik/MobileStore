using OnlineShop.Models;

namespace OnlineShop
{
    public interface ICartsRepository
    {
        void Add(Product product, string userId);
        void Clear();
        void DecreaseAmount(int productId, string userId);
        Cart TruGetByUserId(string userId);
    }
}