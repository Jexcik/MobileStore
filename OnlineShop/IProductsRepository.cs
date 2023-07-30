using OnlineShop.Models;

namespace OnlineShop
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product TryGetById(int id);
    }
}