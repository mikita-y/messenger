using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using messenger.Models;
using System.IO;

namespace messenger.Controllers
{
    public class HomeController : Controller
    {
        //eah
        //User my;
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult window(User user)
        {
            ViewBag.myuser = user;
            return View();
        }

        [HttpPost]
        public IActionResult window(User user, string mess)
        {
            ViewBag.myuser = user;
            FileSupport.Writing(user, mess);
            return View();
        }
        // new comment

        public IActionResult log_in()
        {
            int a;
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
            user = DBsupport.GetUser(user.Name);
           
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
            User my = DBsupport.GetUser(user.Name);
            return RedirectToActionPermanent("window", my);
        }

        public PartialViewResult storage()
        {
            return PartialView();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
