using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly IFavoriteRepository favoriteRepository;

        public FavoriteController(IProductsRepository productsRepository, IFavoriteRepository favoriteRepository)
        {
            this.productsRepository = productsRepository;
            this.favoriteRepository = favoriteRepository;
        }
        public IActionResult Index()
        {
            var favoriteList=favoriteRepository.GetAllFavorite();//Получаем список всех продуктов добавленных в список избранных
            return View(favoriteList);//Передаем в представление список с товарами добавленными в Избранное!!!
        }
        public IActionResult Add(int id)
        {
            var product = productsRepository.TryGetById(id); //Получаем продукт по ID
            favoriteRepository.Add(product); //Добавляем переданный продукт в список избранных
            return RedirectToAction("Index");//Переходим в представление Избранных
        }
        public IActionResult Del(int id)
        {
            var product=productsRepository.TryGetById(id);
            favoriteRepository.Del(product);
            return RedirectToAction("Index");//Переходим в представление Избранных
        }
    }
}
