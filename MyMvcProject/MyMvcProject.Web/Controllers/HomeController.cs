namespace MyMvcProject.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Data.Common;
    using Data.Models;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private IDbRepository<Book> books;
        private IDbRepository<Category> categories;

        public HomeController(IDbRepository<Book> books, IDbRepository<Category> categories)
        {
            this.books = books;
            this.categories = categories;
        }

        public ActionResult Index()
        {
            var booksResult = this.books
                .All()
                .OrderBy(x => Guid.NewGuid())
                .Take(3)
                .Select(x => new BookViewModel() { Resume = x.Resume });

            return this.View(booksResult);
        }
    }
}