﻿using AutoMapper;
using CuscuzAdmin.Models;
using Cuscuzeria.API.Interface;
using Cuscuzeria.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CuscuzAdmin.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserAppService _userApp;

        public UsersController(IUserAppService userApp)
        {
            _userApp = userApp;
        }

        // GET: Users
        public ActionResult Index()
        {
            var userViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userApp.GetAll());
            return View(userViewModel);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            var user = _userApp.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return View(userViewModel);
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
                _userApp.Add(userDomain);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _userApp.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return View(userViewModel);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = Mapper.Map<UserViewModel, User>(user);
                _userApp.Update(userDomain);

                return RedirectToAction("Index");
            }

            return View();

        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            var user = _userApp.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return View(userViewModel);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var user = _userApp.GetById(id);
            _userApp.Remove(user);

            return RedirectToAction("Index");
        }
    }
}