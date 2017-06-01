namespace MyMvcProject.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Categories;

    public class CategoriesController : Controller
    {
        private ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public ActionResult Index()
        {
            var categoriesResult = this.categoriesService
            .GetAll()
            .To<CategoryViewModel>()
            .ToList();

            return this.View(categoriesResult);
        }
    }
}