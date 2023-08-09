using OnlineShop.Models;

namespace OnlineShop
{
    public class CompareInMemoryRepository : ICompareRepository
    {
        public List<Product> compare = new List<Product>();
        public List<Product> GetAllCompare() //Метод для получения списка продуктов для сравнения
        {
            return compare;
        }
        public void Add(Product product)
        {
            if(!compare.Contains(product))
            {
                compare.Add(product);
            }
        }
        public void Clear()
        {
            compare.Clear();
        }
        public void Del(Product product)
        {
            compare.Remove(product);
        }

    }
}
