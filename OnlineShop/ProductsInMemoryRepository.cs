using OnlineShop.Models;
using System.Linq;

namespace OnlineShop
{
    public class ProductsInMemoryRepository : IProductsRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("IPhone 14 ProMax",129000,"Deep Purple","/images/IPhon14.jpg"),
            new Product("Samsung Galaxy S22",98000,"Ultra","/images/Samsung.jpg"),
            new Product("Xiaomi 13 Ultra",42000,"Xseries","/images/Xiaomi13Pro.jpg")
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    }
}
