using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRDemo.ViewModel;

namespace SignalRDemo.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { message = "Login Failed" }, JsonRequestBehavior.AllowGet);
            }

            // If user is not exist
            // return message

            return this.RedirectToAction("Index", "Chat");
        }

    }
}
