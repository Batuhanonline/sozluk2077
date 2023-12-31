﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sozluk2077.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        [Authorize(Roles = "B")]
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetCategories();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                categoryManager.CategoryAdd(category);
                return RedirectToAction("Index");
            } else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = categoryManager.GetByID(id);
            categoryManager.CategoryDelete(categoryValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryValue = categoryManager.GetByID(id);
            return View(categoryValue);
        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            categoryManager.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}