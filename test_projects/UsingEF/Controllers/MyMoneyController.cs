using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.MyMoney;

namespace UsingEF.Controllers
{
    public class MyMoneyController : BaseController
    {

        public ActionResult Index()
        {
            using (var service = GetService())
            {
                var model = service.MyMoneyService.GetAllJournalPaymentsByDate(DateTime.Now);
            return View(model);
            }
            
        }

        public ActionResult AddNewPayment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewPayment(JournalPayment journalPayment)
        {
            using (var service = GetService())
            {
                if (ModelState.IsValid)
                {
                    var jp = new JournalPayment()
                        {
                            Amount = journalPayment.Amount,
                            Currency = journalPayment.Currency,
                            DateTime = DateTime.Now,
                            Description = "First",
                            OperationTypeId = 1,
                            PrioritetId = 1
                        };
                    service.MyMoneyService.AddJournalPayment(jp);
                    //service.MyMoneyContext.JournalPayments.Add(jp);
                    //service.MyMoneyContext.SaveChanges();
                }
                //service.MyMoneyService.AddJournalPayment(journalPayment);
            }

           return RedirectToAction("Index");
        }

    }
}
