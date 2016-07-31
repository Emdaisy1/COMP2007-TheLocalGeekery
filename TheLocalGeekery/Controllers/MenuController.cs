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

namespace TheLocalGeekery.Controllers
{
    public class MenuController : Controller
    {
        private MenuItemEntities menuDB = new MenuItemEntities();

        // GET: StoreManager
        public async Task<ActionResult> Index()
        {
            var menuItems = menuDB.MenuItems;
            return View(await menuItems.ToListAsync());
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItem menuItem = await menuDB.MenuItems.FindAsync(id);
            if (menuItem == null)
            {
                return HttpNotFound();
            }
            return View(menuItem);
        }
    }
}