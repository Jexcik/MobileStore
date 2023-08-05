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
            var compareList = compareRepository.GetAllCompare();
            return View(compareList);
        }
        public IActionResult Add(int id)
        {
            var product=productsRepository.TryGetById(id); //Получаем продукт по ID
            compareRepository.Add(product);
            return RedirectToAction("Index");
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
