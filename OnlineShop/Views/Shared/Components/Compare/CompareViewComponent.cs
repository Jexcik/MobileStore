using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Views.Shared.Components.Compare
{
    public class CompareViewComponent:ViewComponent
    {
        private readonly ICompareRepository compareRepository;

        public CompareViewComponent(ICompareRepository compareRepository)
        {
            this.compareRepository = compareRepository;
        }
        public IViewComponentResult Invoke()
        {
            var compareList = compareRepository.GetAllCompare();
            return View("Compare", compareList);
        }
    }
}
