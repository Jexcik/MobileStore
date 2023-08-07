using OnlineShop.Models;
using System.Linq;

namespace OnlineShop
{
    public class ProductsInMemoryRepository : IProductsRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("IPhone 14 ProMax",129000,$"IOS; A16 Bionic; 256ГБ; 48МП","/images/IPhon14.jpg"),
            new Product("Samsung Galaxy S22",98000,"Android 12; Samsung Exynos 2200; 256ГБ; 108МП","/images/Samsung.jpg"),
            new Product("Xiaomi 13 Ultra",42000,"Android 13; Qualcomm Snapdragon 8 Gen 2; 512ГБ; 50МП","/images/Xiaomi13Pro.jpg"),
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
