using OnlineShop.Models;

namespace OnlineShop
{
    public interface IFavoriteRepository
    {
        void Add(Product product);
        void Clear();
        void Del(Product product);
        List<Product> GetAllFavorite();

    }
}