using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BookRepositorySeedData : IBookRepository
    {
        private BookContext _context;
        public BookRepositorySeedData(BookContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => new List<Book>
        {
            new Book
            {
                Titel="Anna Karenina",
                Erscheinungsdatum=DateTime.Today,
                Autor="Leo Tolstoy",
                Page=864,
                Language="Russian",
                Stock=3
            },
            new Book
            {
                Titel="Madame Bovary",
                Erscheinungsdatum=DateTime.Today,
                Autor="Gustave Flaubert",
                Page=465,
                Language="French",
                Stock=2
            },
        }.AsQueryable();

        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int BookId)
        {
            throw new NotImplementedException();
        }

        public Book Detail(int BookId)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int BookId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
