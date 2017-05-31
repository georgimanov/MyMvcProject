﻿namespace MyMvcProject.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data.Models;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Services.Data;
    using ViewModels.Books;

    [Authorize]
    public class BooksController : BaseController
    {
        private IBooksService booksService;
        private ICategoriesService categoriesService;

        public BooksController(IBooksService booksService, ICategoriesService categoriesService)
        {
            this.booksService = booksService;
            this.categoriesService = categoriesService;
        }

        public ActionResult Index()
        {
            var booksResult = this.booksService
                .GetAll()
                .To<BookViewModel>()
                .ToList();

            return this.View(booksResult);
        }

        [HttpGet]
        public ActionResult ById(int id)
        {
            var bookResult = this.booksService.GetBookById(id);

            var viewModel = AutoMapperConfig.Configuration.CreateMapper().Map<BookViewModel>(bookResult);

            return this.View(viewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var bookInputViewModel = new BookInputModel
            {
                Category = this.categoriesService
                    .GetAll()
                    .ToList()
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    })
            };

            return this.View(bookInputViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Add(BookInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                var book = new Book
                {
                    Title = model.Title,
                    Resume = model.Resume,
                    CategoryId = model.CategoryId,
                };

                this.booksService.Add(book);

                this.TempData["Notification"] = "Book added successfully";

                return this.RedirectToAction("Index");
            }

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            this.booksService.Delete(id);

            return this.RedirectToAction("Index");
        }
    }
}