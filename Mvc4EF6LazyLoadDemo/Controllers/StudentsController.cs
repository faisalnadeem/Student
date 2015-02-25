using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4EF6LazyLoadDemo.DataContext;
using Mvc4EF6LazyLoadDemo.Models;

namespace Mvc4EF6LazyLoadDemo.Controllers
{
    public class StudentsController : Controller
    {
		private ApplicationDbContext _db = new ApplicationDbContext();
        //
        // GET: /Students/

        public ActionResult Index()
        {
			
            return View(_db.Students);
        }

        //
        // GET: /Students/Details/5

        public ActionResult Details(int id)
        {
        	var student = _db.Students.Find(id);
			_db.Entry(student).Reference(s=> s.Course).Load();
			_db.Entry(student).Reference(s=> s.Instructor).Load();
            return View(student);
        }

        //
        // GET: /Students/Create

        public ActionResult Create()
        {
        	var student = new Student();
			student.Course = new Course();
			student.Instructor = new Instructor();

			_db.Entry(student).Collection<CourseBook>(s=> s.Books).Load();

			ViewBag.CourseTypeId = _db.CourseTypes.Select(t=> new SelectListItem(){Text = t.Description , Value = t.Id.ToString()}).ToList();
        	ViewBag.SelectedCourseTypeDescription = _db.CourseTypes.FirstOrDefault().Description;
			ViewBag.CourseBookTypeId = student.Books.Select(t=> new SelectListItem(){Text = t.Description , Value = t.Id.ToString()}).ToList();
            return View(student);
        }

        //
        // POST: /Students/Create

        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
            	_db.Students.Add(student);
            	_db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Students/Edit/5

        public ActionResult Edit(int id)
        {
			var student = _db.Students.Find(id);
        	var instructorList = _db.Instructors;
        	var courseList = _db.Courses;

        	ViewBag.InstructorId = new SelectList(instructorList, "Id", "Surname",
        	                                      instructorList.FirstOrDefault(x => x.Id == student.InstructorId).Id);
        	ViewBag.CourseId = new SelectList(courseList, "Id", "Name",
        	                                      courseList.FirstOrDefault(x => x.Id == student.CourseId).Id);
			_db.Entry(student).Reference(s => s.Course).Load();
			_db.Entry(student).Reference(s => s.Instructor).Load();

			return View(student);
        }

        //
        // POST: /Students/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
            	var courseOrg = _db.Courses.Find();
//            	_db.Entry();

//				_db.Entry(student.Course).Property(c => c.Name).IsModified = true;// .State = EntityState.Modified;
                // TODO: Add update logic here
				_db.Entry(student).State = EntityState.Modified;

//				_db.ChangeTracker.Entries<>()
//            	_db.Students.Attach(student).Course = EntityState.Modified;
            	_db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        //
        // GET: /Students/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Students/Delete/5

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
