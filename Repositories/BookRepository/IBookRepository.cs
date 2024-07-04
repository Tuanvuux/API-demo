using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookRepository
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        Book Add(Book book);
        void Update(Book book);
        void Delete(int id);

    }
}
