using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Views.Shared.Components.Favorite
{
    public class FavoriteViewComponent:ViewComponent
    {
        private readonly IFavoriteRepository favoriteRepository;

        public FavoriteViewComponent(IFavoriteRepository favoriteRepository)
        {
            this.favoriteRepository = favoriteRepository;
        }
        public IViewComponentResult Invoke()
        {
            var fovorite = favoriteRepository.GetAllFavorite();
            return View("Favorite", fovorite);
        }

    }
}
