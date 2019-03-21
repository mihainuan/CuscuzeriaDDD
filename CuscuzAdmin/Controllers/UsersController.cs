using AutoMapper;
using CuscuzAdmin.Models;
using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Infra.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CuscuzAdmin.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserRepository _userRepository = new UserRepository();

        // GET: Users
        public ActionResult Index()
        {
            var userViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userRepository.GetAll());
            return View(userViewModel);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = Mapper.Map<UserViewModel, User>(user);
                _userRepository.Add(userDomain);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}