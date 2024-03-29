﻿using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Controllers;
using BurgerMVCProject.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCProject.UI.Controllers.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MenuController : Controller
    {
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {

            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            menuService.AddMenu(menu);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int menuId)
        {
            Menu menu = menuService.GetByIdMenu(menuId);
            return View();
        }

        [HttpPost]
        public IActionResult Update(Menu menu)
        {
            menuService.UpdateMenu(menu);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int menuId)
        {
            Menu menu = menuService.GetByIdMenu(menuId);
            menuService.DeleteMenu(menu);
            return RedirectToAction("Index");
        }
    }
}
