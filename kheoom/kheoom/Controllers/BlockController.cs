using DocumentFormat.OpenXml.InkML;
using kheoom.Models;
using kheoom.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kheoom.Controllers
{
    public class BlockController : Controller
    {
        private readonly dataContext context;
        public BlockController(dataContext Context)
        {
            context = Context;
        }
        [HttpGet]
        public IActionResult AddBlock()
        {
            return View();
        }
        public IActionResult AddBlock(BlockVM block)
        {
            if (ModelState.IsValid)
            {
                Block obj = new Block();
                obj.BlockId = block.BlockId;
                obj.Name = block.Name;
                obj.Notes = block.Notes;


                context.Blocks.Add(obj);
                context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
