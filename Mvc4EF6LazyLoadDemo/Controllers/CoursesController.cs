using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4EF6LazyLoadDemo.DataContext;

namespace Mvc4EF6LazyLoadDemo.Controllers
{
    public class CoursesController : Controller
    {
		ApplicationDbContext _db = new ApplicationDbContext();
        //
        // GET: /Courses/

        public ActionResult Index()
        {
        	var model = _db.Courses;
            return View(model);
        }

        //
        // GET: /Courses/Details/5

        public ActionResult Details(int id)
        {
        	var model = _db.Courses.Find(id);
            return View(model);
        }

        //
        // GET: /Courses/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Courses/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Courses/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Courses/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Courses/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Courses/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
