namespace MyMvcProject.Services.Data
{
    using MyMvcProject.Data.Models;
    using System.Linq;

    public interface IBooksService
    {
        IQueryable<Book> GetRandomBooks(int count);

        IQueryable<Book> GetAll();

        Book GetBookById(int id);

        void Add(Book book);

        void Delete(int bookId);

        void Update(Book book);
    }
}
