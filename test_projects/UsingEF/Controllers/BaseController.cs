using System.Web.Mvc;
using Domain;
using Domain.DataContexts;
using Services;

namespace UsingEF.Controllers
{
    public class BaseController : Controller
    {
        protected Service GetService()
        {
            return new Service()
                {
                    DbBooksContext = new BooksContext()
                    ,MyMoneyContext = new MyMoneyContext()
                };
        }
    }
}
