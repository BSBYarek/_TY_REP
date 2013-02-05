using System;
using System.Data.Entity;
using Domain;
using Domain.DataContexts;
using Services.MyMoney;

namespace Services
{
    public class Service : IService
    {
        public BookService BookServices { get; private set; }
        public FlowerService FlowerService { get; private set; }
        public MyMoneyService MyMoneyService { get; private set; }

        public Service()
        {
            InitConnectionString();
            InitServices();
        }


        private void InitServices()
        {
            InitService(BookServices = new BookService());
            InitService(FlowerService = new FlowerService());
            InitService(MyMoneyService = new MyMoneyService());
        }

        private void InitService(IBaseService service)
        {
            service.Service = this;
        }


        public BooksContext DbBooksContext { get; set; }
        public MyMoneyContext MyMoneyContext { get; set; }

         private void InitConnectionString()
         {
             DbBooksContext = new BooksContext();
             MyMoneyContext = new MyMoneyContext();
         }

        public void Commit()
        {
            if (DbBooksContext != null)
            {
                DbBooksContext.SaveChanges();
            }
            if (MyMoneyContext != null)
            {
                MyMoneyContext.SaveChanges();
            }
        }

        public void Dispose()
        {
            Commit();
            if (DbBooksContext != null)
            {
                DbBooksContext.Dispose();
            }
            if (MyMoneyContext != null)
            {
                MyMoneyContext.Dispose();
            }
        }
    }
}
