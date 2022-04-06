using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuyList.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult SignUp()
        {
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