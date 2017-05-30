namespace MyMvcProject.Services.Data
{
    using MyMvcProject.Data.Common;
    using MyMvcProject.Data.Models;
    using System;
    using System.Linq;

    public class BooksService : IBooksService
    {
        private IDbRepository<Book> books;

        public BooksService(IDbRepository<Book> books)
        {
            this.books = books;
        }

        public IQueryable<Book> GetRandomBooks(int count)
        {
            return this.books
                    .All()
                    .OrderBy(x => Guid.NewGuid())
                    .Take(count);
        }
    }
}
