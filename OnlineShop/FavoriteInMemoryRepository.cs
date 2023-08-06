using OnlineShop.Models;

namespace OnlineShop
{
    public class FavoriteInMemoryRepository : IFavoriteRepository
    {
        public List<Product> favorite = new List<Product>(); //Заводим список для хранения избранных продуктов
        public void Add(Product product)
        {
            if(!favorite.Contains(product)) //Проверяет содержится ли в списке данный элемент
            {
                favorite.Add(product); //Если нет, то добавляется в список переданный элемент
            }
        }
        public void Clear()
        {
            favorite.Clear();// Очистка списка избранных
        }
        public void Del(Product product)
        {
            favorite.Remove(product);//Удаляется из списка переданный элемент
        }
        public List<Product> GetAllFavorite()
        {
            return favorite; //Получаем список всех избранных продуктов
        }
    }
}
