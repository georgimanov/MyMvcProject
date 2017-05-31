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

        public void Add(Book book)
        {
            this.books.Add(book);
            this.books.Save();
        }

        public void Delete(int bookId)
        {
            var book = this.books.GetById(bookId);
            this.books.Delete(book);
            this.books.Save();
        }

        public void Update(Book book)
        {
            var oldBook = this.books.GetById(book.Id);
            oldBook = book;
            this.books.Save();
        }

        public Book GetBookById(int id)
        {
            return this.books.GetById(id);
        }

        public IQueryable<Book> GetRandomBooks(int count)
        {
            return this.books
                    .All()
                    .OrderBy(x => Guid.NewGuid())
                    .Take(count);
        }

        public IQueryable<Book> GetAll()
        {
            return this.books.All();
        }
    }
}
