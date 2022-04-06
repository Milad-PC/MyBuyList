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
        private MyContext _context;

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
        [AllowAnonymous][HttpPost]
        public ActionResult SignUp(User input)
        {
            FormsAuthentication.SetAuthCookie(input.UserID.ToString() , true);
            return View();
        }
        public ActionResult AddList()
        {
            return View();
        }
        
        public ActionResult AddTask()
        {
            return View();
        }
    }
}