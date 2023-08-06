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
            var product = productsRepository.TryGetById(id);
            favoriteRepository.Add(product);
            return RedirectToAction("Index");
        }
    }
}
