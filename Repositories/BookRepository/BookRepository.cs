using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly APIDbContext _context;

        public BookRepository(APIDbContext context)
        {
            _context = context;
        }
        public Book GetById(int id)
        {
            return _context.Set<Book>().Find(id);
        }
        public List<Book> GetAll()
        {
            return _context.Set<Book>().ToList();
        }

        public Book Add(Book book)
        {
            _context.Set<Book>().Add(book);
            _context.SaveChanges();
            return book;
        }

        public void Delete(int id)
        {
            var bookToDelete = _context.Set<Book>().Find(id);
            if (bookToDelete != null)
            {
                _context.Set<Book>().Remove(bookToDelete);
                _context.SaveChanges();
            }

        }


        public void Update(Book book)
        {
            var existingBook = _context.Set<Book>().Find(book.BookId);
            if (existingBook != null)
            {
                existingBook.Name = book.Name;
                existingBook.Description = book.Description;

                _context.SaveChanges();
            }
        }
    }
}
