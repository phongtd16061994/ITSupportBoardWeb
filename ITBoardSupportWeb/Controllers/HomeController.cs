﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITBoardSupportWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Onboard()
        {
            ViewBag.Message = "Page process On.";

            return View();
        }
        public ActionResult Offboard()
        {
            ViewBag.Message = "Page process offboard.";

            return View();
        }
        public ActionResult Buydevice()
        {
            ViewBag.Message = "Page process Buy Device.";

            return View();
        }
    }
}