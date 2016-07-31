using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheLocalGeekery.Models;

//Author: Emma Hilborn - 200282755
//File: MenuController.cs
//Website: http://thelocalgeekery.azurewebsites.net/
//Date: July 31, 2016
//Version: 1.0.0
//Description: The controller for the menu view pages, index (being the menu) and details

namespace TheLocalGeekery.Controllers
{
    public class MenuController : Controller
    {
        private MenuItemEntities menuDB = new MenuItemEntities();

        //Load the index page, passing in a variable to set the current page and the menu items as a variable to use on the page
        public async Task<ActionResult> Index()
        {
            ViewBag.Current = "Menu";
            var menuItems = menuDB.MenuItems;
            return View(await menuItems.ToListAsync());
        }
        //Load the details page, passing in a variable (the selected menu item, or default to 1) for the view's information
        public async Task<ActionResult> Details(int id = 1)
        {
            ViewBag.Current = "Menu";
            MenuItem menuItem = await menuDB.MenuItems.FindAsync(id);
            if (menuItem == null)
            {
                return HttpNotFound();
            }
            return View(menuItem);
        }
    }
}