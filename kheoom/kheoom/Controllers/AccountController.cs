using DocumentFormat.OpenXml.InkML;
using kheoom.Models;
using Microsoft.AspNetCore.Mvc;

namespace kheoom.Controllers
{
    public class AccountController : Controller
    {
        private readonly dataContext context;
        public AccountController(dataContext Context)
        {
            context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            
            
            string cookieValue = Request.Cookies["username"];
            if (string.IsNullOrEmpty(cookieValue))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }
        [HttpPost]
        public IActionResult SignIn(string username, string password)
        {


            try
            {
                var obj = context.Users.Where(a => a.UserName.Equals(username) && a.Password.Equals(password)).FirstOrDefault();
                if (obj != null)
                {
                    CookieOptions option = new CookieOptions();
                    option.Expires = DateTime.Now.AddMinutes(12220);
                    Response.Cookies.Append("username", username, option);

                    return Json(obj);
                }
                return Json(-1);
            }
            catch
            {
                return Json("0");

            }

        }

        public IActionResult SignOut()
        {
            Response.Cookies.Delete("username");

            return RedirectToAction("SignIn");

        }
    }
}
