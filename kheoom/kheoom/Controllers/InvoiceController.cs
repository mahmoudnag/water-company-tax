using kheoom.Models;
using kheoom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace kheoom.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly dataContext context;
        public InvoiceController(dataContext Context)
        {
            context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllInvoice()
        {
            var invoices = context.Invoices.Select(x => new InvoiceVM
            {
                System_InvoiceID = x.System_InvoiceID,
                System_SubscriptionID = x.System_SubscriptionID,
                SubscriberID = x.SubscriberID,
                SubscriberName = x.SubscriberID,
                DataEntry = x.DataEntry,
                LastRead = x.LastRead,
                NowRead = x.NowRead,
                Consumption_Amount = x.Consumption_Amount,
                Invoice_Value_ = x.Invoice_Value_,
                Invoice_All_Value_ = x.Invoice_All_Value
            }).ToList();
            return View(invoices);
        }
        public IActionResult Delete(int id)
        {
            var invoice= context.Invoices.FirstOrDefault(x => x.System_InvoiceID == id);
            context.Invoices.Remove(invoice);
            context.SaveChanges();
            return RedirectToAction("GetAllInvoice");
        }
        
    }
}
