﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sozluk2077.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactValidator = new ContactValidator();
        public ActionResult Index()
        {
            var contactValues = contactManager.GetAll();
            return View(contactValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.GetById(id);
            return View(contactValues);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}