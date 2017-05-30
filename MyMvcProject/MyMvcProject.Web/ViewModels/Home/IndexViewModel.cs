namespace MyMvcProject.Web.ViewModels.Home
{
    using System.Collections.Generic;

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