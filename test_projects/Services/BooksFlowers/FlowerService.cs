using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using Domain.Entities;

namespace Services
{
    public class FlowerService : BaseService
    {
        private BooksContext DbBooksContext;

        //public FlowerService()
        //{
        //    if (Db == null) Db = new EFDbContext();
        //    Db.Configuration.LazyLoadingEnabled = false;
        //}

        public List<Flower> GetAllFlowerss()
        {
            return DbBooksContext.Flowers.ToList();
        }

        public Flower GetFlowerById(int Id)
        {
            return (from b in DbBooksContext.Flowers
                    where b.ID == Id
                    select b).FirstOrDefault();
        }
    }
}
