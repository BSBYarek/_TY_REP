using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsingEF.Controllers
{
    public class BooksController : BaseController
    {
        private int pageSize = 10;

        public ActionResult Index(int pageNum = 0)
        {
            using (var service = GetService())
            {
                ViewData["pageNum"] = pageNum;
                ViewData["itemsCount"] = service.BookServices.GetAllBooks().Count;
                ViewData["pageSize"] = pageSize;
                var model = service.BookServices.GetBooksOnPage(pageSize, pageNum);
                if (!Request.IsAjaxRequest())
                {
                    return View(model);
                }
                else
                {
                    return PartialView("IndexPage", model);
                }
            }
        }

    }
}
