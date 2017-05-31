namespace MyMvcProject.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Books;

    public class IndexViewModel
    {
        public IEnumerable<CategoryViewModel> Categories
        {
            get; set;
        }

        public IEnumerable<BookViewModel> Books
        {
            get; set;
        }
    }
}