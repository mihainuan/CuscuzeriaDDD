using Cuscuzeria.API.Interface;
using Cuscuzeria.MVC.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MyCuscuzAdminWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserAppService _userApp;

        private ConnDb connDB = new ConnDb();
        public IActionResult Index()
        {
            if (CheckLogin().Equals(true))
            {
                return View();
            }
            else
            {
                return View("Login");
            }

        }

        public IActionResult Login(string email, string password)
        {
            DataTable dt = connDB.GetData($"SELECT * FROM clients WHERE Email = '{email}'");
            //If e-mail exists
            if (dt.Rows.Count > 0)
            {
                //If password exists
                //if (dt.Rows[0]["Password"].ToString() == EncodeString.MD5HashCryptography(password))
                if (dt.Rows[0]["Password"].ToString() == password)
                {
                    HttpContext.Session.SetString("login", "1");
                    return RedirectToAction("Index", "Home");
                    //return Redirect("/Home/Index");
                    //return View("../Home/Main");
                }
            }
            return View();
        }

        private bool CheckLogin()
        {
            bool result = false;
            if (HttpContext.Session.GetString("login") != null)
            {
                if (HttpContext.Session.GetString("login") == "1")
                {
                    result = true;
                }
            }

            return result;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

    }
}