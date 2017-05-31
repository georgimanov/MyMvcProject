namespace MyMvcProject.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private IBooksService booksService;
        private ICategoriesService categoriesService;

        public HomeController(IBooksService booksService, ICategoriesService categoriesService)
        {
            this.booksService = booksService;
            this.categoriesService = categoriesService;
        }

        public ActionResult Index()
        {
            var booksResult = this.booksService
                .GetRandomBooks(3)
                .To<BookViewModel>()
                .ToList();

            var categoriesResult = this.Cache.Get(
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