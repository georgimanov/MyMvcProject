namespace MyMvcProject.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using Services.Web;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private IBooksService booksService;
        private ICategoriesService categoriesService;
        private ICacheService cacheService;

        public HomeController(IBooksService booksService, ICategoriesService categoriesService, ICacheService cacheService)
        {
            this.booksService = booksService;
            this.categoriesService = categoriesService;
            this.cacheService = cacheService;
        }

        public ActionResult Index()
        {
            var booksResult = this.booksService
                .GetRandomBooks(3)
                .To<BookViewModel>()
                .ToList();

            var categoriesResult = this.cacheService.Get(
                "categories",
                () => this.categoriesService.GetAll().To<CategoryViewModel>().ToList(),
                30 * 60);

            var indexViewModel = new IndexViewModel();
            indexViewModel.Books = booksResult;
            indexViewModel.Categories = categoriesResult;

            return this.View(indexViewModel);
        }
    }
}