using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Author: Emma Hilborn - 200282755
//File: HomeController.cs
//Website: http://thelocalgeekery.azurewebsites.net/
//Date: July 31, 2016
//Version: 1.0.0
//Description: The controller for the "Home" views (index & contact)

namespace TheLocalGeekery.Controllers
{
    public class HomeController : Controller
    {
        //Load the index page, pass in a viewbag option to set current page
        public ActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }
        //Load the contact page, pass in a viewbag option to set current page
        public ActionResult Contact()
        {
            ViewBag.Current = "Contact";
            return View();
        }
    }
}