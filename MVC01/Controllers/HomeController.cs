﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC01.Models;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dao = new DaoTutoriales();
            ViewBag.Lista = dao.tutorialesQry();
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
    }
}