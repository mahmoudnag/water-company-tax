using kheoom.Models;
using Microsoft.AspNetCore.Mvc;

namespace kheoom.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly dataContext context;
        public SubscriptionController(dataContext Context)
        {
            context = Context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllSubscription()
        {
            var subsription=context.SubScribptions.ToList();
            return View(subsription);
        }
        [HttpPost]
        public IActionResult SubscribptionUpdateRate(decimal nowread,string SubscriberID)
        {
            try
            {
                var subsription = context.SubScribptions.FirstOrDefault(x => SubscriberID == SubscriberID);
                subsription.LastRead = nowread;
                context.SaveChanges();
                return Json("read update");
            }
            catch { return Json("read not update"); }
        }
        public IActionResult Delete(int id)
        {
          
                var subsription = context.SubScribptions.FirstOrDefault(x =>x.SystemsubsriptionId==id);
                context.SubScribptions.Remove(subsription);
                context.SaveChanges();
            return RedirectToAction("GetAllSubscription");
          
        }
        
    }
}
