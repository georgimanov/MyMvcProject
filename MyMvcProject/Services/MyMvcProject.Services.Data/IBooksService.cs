namespace MyMvcProject.Services.Data
{
    using MyMvcProject.Data.Models;
    using System.Linq;

    public interface IBooksService
    {
        IQueryable<Book> GetRandomBooks(int count);
    }
}
