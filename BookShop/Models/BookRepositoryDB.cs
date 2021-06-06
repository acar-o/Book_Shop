using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BookRepositoryDB : IBookRepository
    {
        private BookContext _context;
        public BookRepositoryDB(BookContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;

        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int BookId)
        {
            Book book = GetById(BookId);
            if (book != null)
            {
                _context.Remove(book);
                _context.SaveChanges();
            }
        }

        public Book Detail(int BookId)
        {
            Book book = GetById(BookId);
            return book;
        }

        public Book GetById(int BookId)
        {
            return _context.Books.FirstOrDefault(i => i.Id == BookId);
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}
