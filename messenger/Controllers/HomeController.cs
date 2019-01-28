using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using messenger.Models;

namespace messenger.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult log_in()
        {
            return View();
        }
        [HttpPost]
        public IActionResult log_in(User user)
        {
            ViewBag.except = 0;
            string pas = DBsupport.search(user.Name);
            if (pas == "")
            {
                ViewBag.except = 1;
                return View();
            }
            if (user.Pass != pas)
            {
                ViewBag.except = 2;
                return View();
            }
            user.Pass = "";
            return RedirectToActionPermanent("window", user);
        }

        public IActionResult registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult registration(User user)
        {
            ViewBag.except = 0;
            string pas = DBsupport.search(user.Name);
            if (pas != "")
            {
                ViewBag.except = 1;
                return View();
            }
            DBsupport.add(user.Name, user.Pass);
            user.Pass = "";
            return RedirectToActionPermanent("window", user);
        }

        public IActionResult window(User user)
        {
            ViewBag.name = user.Name;
            return View();
        }
        [HttpPost]
        public IActionResult window(string name, string mess)
        {
            ViewBag.name = name;
            FileSupport.Writing(name, mess);
            return View();
        }
        public PartialViewResult storage()
        {
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
