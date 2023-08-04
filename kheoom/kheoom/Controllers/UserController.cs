using kheoom.Models;
using kheoom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace kheoom.Controllers
{
    public class UserController : Controller
    {
        private readonly dataContext context;
        public UserController(dataContext Context)
        {
            context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
     
        [HttpGet]
        public IActionResult AddSubscriber()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSubscriber(SubScriberVM subScriber)
        {
            if (ModelState.IsValid)
            {
                SubScriber obj = new SubScriber();
                obj.Name = subScriber.Name;
                obj.IdIdentity = subScriber.IdIdentity;
                obj.phone = subScriber.phone;
                obj.city = subScriber.city;
                obj.area = subScriber.area;
                obj.Notes = subScriber.Notes;
                context.SubScribers.Add(obj);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddSubscription()
        {
            var SubscrbersIDS= context.SubScribers.Select(x => new SubScriberVM
            {
                IdIdentity = x.IdIdentity
            }).ToList();
            var Blocks = context.Blocks.ToList();

            var subscribersIDsAndBlocks = new SubscribersIDsAndBlocks();
            subscribersIDsAndBlocks.subsceribersIDs = SubscrbersIDS;
            subscribersIDsAndBlocks.blocks = Blocks;
            ViewBag.data = subscribersIDsAndBlocks;

            return View();
        }
        [HttpPost]
        public IActionResult AddSubscription(SubScribptionVM subScribption)
        {
            if (ModelState.IsValid)
            {
                SubScribption obj = new SubScribption();
                obj.SystemsubsriptionId = subScribption.SystemsubsriptionId;
                obj.SubscriberID = subScribption.SubscriberID;
                obj.SubscriberName = subScribption.SubscriberName;
                obj.city = subScribption.city;
                obj.area = subScribption.area;
                obj.phone = subScribption.phone;
                obj.BlockType = subScribption.BlockType;
                obj.BlockNumbers = subScribption.BlockNumbers;
                obj.Sanitation = subScribption.Sanitation;
                obj.Notes = subScribption.Notes;
                context.SubScribptions.Add(obj);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult AddInvice()
        {
            var subscriptions = context.SubScribptions.ToList();
            ViewBag.data = subscriptions;
            return View();
        }
        [HttpPost]
        public IActionResult AddInvice( InvoiceVM invoice)
        {
            
            if (ModelState.IsValid)
            {
                Invoice obj = new Invoice();
                obj.System_InvoiceID = invoice.System_InvoiceID;
                obj.SubscriberID = invoice.SubscriberID;
                obj.SubscriberName= invoice.SubscriberName;
                obj.System_SubscriptionID= invoice.System_SubscriptionID;
                obj.NowRead=invoice.NowRead;
                obj.LastRead=invoice.LastRead;
                obj.DataEntry = invoice.DataEntry;
                obj.FromDate = invoice.FromDate;
                obj.ToDate = invoice.ToDate;
                obj.ConsumptionValue_Sanitation= invoice.ConsumptionValue_Sanitation;
                obj.ConsumptionValue_Water = invoice.ConsumptionValue_Water;
                obj.Consumption_Amount = invoice.Consumption_Amount;
                obj.Invoice_Value_ = invoice.Invoice_Value_;
                obj.Invoice_All_Value = invoice.Invoice_All_Value_;
                obj.subscription_BlockNumbers= invoice.subscription_BlockNumbers;
                obj.Sanitation= invoice.Sanitation;
                obj.Service_Fee= invoice.Service_Fee;
                obj.Tax_rate = invoice.Tax_rate;
                obj.Notes = invoice.Notes;
                


                context.Invoices.Add(obj);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
       
        [HttpPost]
      
        [HttpGet]
        public IActionResult AddSlice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSlice(Slice slice)
        {
            if (ModelState.IsValid)
            {
                context.Slices.Add(slice);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult getSubscriber(string ID)
        {
            try
            {
                var subscruber=context.SubScribers.FirstOrDefault(x=>x.IdIdentity==ID);
                return Json(subscruber);

            }
            catch { return Json("error"); }
        }

       
   [HttpPost]
        public IActionResult getSubscribption(string ID)
        {
            try
            {
                var subscrubption = context.SubScribptions.FirstOrDefault(x => x.SubscriberID==ID);
                return Json(subscrubption);

            }
            catch { return Json("subscrubption"); }
        }

    }
}
