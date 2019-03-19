﻿using Cuscuzeria.MVC.DB;
using CuscuzeriaDDD.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace CuscuzeriaDDD.MVC.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login(string username, string password)
        {
            DataTable dt = connDB.GetData($"SELECT * FROM cuscuzeriadb.clients WHERE Name = '{username}'");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Password"].ToString() == EncodeString.MD5HashCryptography(password))
                {
                    HttpContext.Session.SetString("login", "1");
                    return View("Index");
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
    }
}
