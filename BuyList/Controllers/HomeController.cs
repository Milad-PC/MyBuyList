using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DataLayer;

namespace BuyList.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private MyContext _context = new MyContext();
        IUserRepository usr;
        public HomeController()
        {
            usr = new UserRepository(_context);

        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(int id)
        {
            return View();
        }
        public ActionResult ShareList()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string UserName , string Password)
        {
            if (usr.Existed(UserName, Password))
            {
                FormsAuthentication.SetAuthCookie(usr.Get(UserName).UserID.ToString(), true);
                return RedirectToAction("Index");
            }
            return View();
        }
        [AllowAnonymous][HttpPost]
        public ActionResult SignUp(User input)
        {
            try
            {
                usr.Insert(input);
                usr.Save();
                FormsAuthentication.SetAuthCookie(input.UserID.ToString(), true);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(input);
            }
        }
        public ActionResult AddList()
        {
            return View();
        }
        
        public ActionResult AddTask()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult SignOut(int id)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}