﻿using MvcStokTakip.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStokTakip.Models.Entity;

namespace MvcStokTakip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DbMvcStokEntities db = new DbMvcStokEntities();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniAdmin()
        {
            return View();
        
        }

        [HttpPost]
        public ActionResult YeniAdmin(tbladmin p)
        {
            db.tbladmin.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}