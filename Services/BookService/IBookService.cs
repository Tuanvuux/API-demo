using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BookService
{
    public interface IBookService
    {
        Book GetById(int id);
        List<Book> GetAll();
        Book Add(Book book);
        void Delete(int id);
        void Update(Book book);
    }
}
