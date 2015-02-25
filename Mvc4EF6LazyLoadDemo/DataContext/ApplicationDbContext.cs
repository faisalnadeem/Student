using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Mvc4EF6LazyLoadDemo.Models;

namespace Mvc4EF6LazyLoadDemo.DataContext
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }

		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<Course> Courses { get; set; } 
		public DbSet<CourseType> CourseTypes { get; set; }
		public DbSet<CourseBook> CourseBooks { get; set; }
		public DbSet<BookType> BookTypes { get; set; }
		public DbSet<AssociatedBooks> AssociatedBooks { get; set; } 

	}
}