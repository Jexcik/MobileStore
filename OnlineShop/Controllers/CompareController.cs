using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class CompareController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICompareRepository compareRepository;

        public CompareController(IProductsRepository productsRepository, ICompareRepository compareRepository)
        {
            this.productsRepository = productsRepository;
            this.compareRepository = compareRepository;
        }

        public IActionResult Index()
        {
            var compareList = compareRepository.GetAllCompare();//Получаем список всех товаров добавленных в Сравнение!!!
            return View(compareList);//Передаем список с продуктами добавленными в сравнение в Представление
        }
        public IActionResult Add(int id)
        {
            var product=productsRepository.TryGetById(id); //Получаем продукт по ID
            compareRepository.Add(product);//Добавляем переданный продукт 
            return RedirectToAction("Index");//Переходим на страницу с списком для Сравнения
        }
        public IActionResult Del(int id) 
        {
            var product = productsRepository.TryGetById(id);//Получаем продукт по ID
            compareRepository.Del(product);//удаляем переданный продукт из списка продуктов
            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            compareRepository.Clear();
            return RedirectToAction("Index");
        }
    }
}
