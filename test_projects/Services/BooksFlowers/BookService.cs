using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Entities;

namespace Services
{
    public class BookService : BaseService
    {
        public List<Book> GetAllBooks()
        {
            return Service.DbBooksContext.Books.OrderBy(_ => _.Title).ToList();
        }

        public List<Book> GetBooksOnPage(int pageSize,int pageNum)
        {
            return Service.DbBooksContext.Books.OrderBy(_ => _.Title).Skip(pageSize * pageNum).Take(pageSize).ToList();
        }

        public Book GetBookById(int id)
        {
            //return (from b in Service.Db.Books
            //        where b.Id == id
            //        select b.Id).FirstOrDefault();

            return Service.DbBooksContext.Books.FirstOrDefault(_ => _.Id == id);
        }
    }
}
