namespace MyMvcProject.Web.ViewModels.Home
{
    using MyMvcProject.Data.Models;
    using MyMvcProject.Web.Infrastructure.Mapping;

    public class BookViewModel : IMapFrom<Book>
    {
        public string Resume
        {
            get; set;
        }
    }
}