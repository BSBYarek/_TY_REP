using System.Data.Entity;
using System.Web.Mvc;


namespace UsingEF.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(int pageNum = 0)
        {
           return View();        
        }

    }
}
