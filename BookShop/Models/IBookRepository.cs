using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
        void CreateBook(Book book);
        void UpdateBook(Book book);
        Book GetById(int BookId);
        void Delete(int BookId);
        Book Detail(int BookId);
        

    }
}
