using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mvc4EF6LazyLoadDemo.Models;

namespace Mvc4EF6LazyLoadDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc4EF6LazyLoadDemo.DataContext.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        	AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Mvc4EF6LazyLoadDemo.DataContext.ApplicationDbContext context)
        {
			context.Students.AddOrUpdate(s => s.Fullname,
											new Student() { Fullname = "Test Student1", Instructor = new Instructor() { Designation = "Designatin1", Forename = "Forename1", Surname = "Surname1" }, Course = new Course() { Description = "Test Course1", Name = "Test coursename1", Type = new CourseType() { Description = "Coursetype1", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator11" }, new CourseCoordinator() { Name = "Coordinator12" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook11", Type = new BookType() { Description = "BookType11", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook111" }, new AssociatedBooks() { Description = "AssociatedBook112" } } } } } },
											new Student() { Fullname = "Test Student2", Instructor = new Instructor() { Designation = "Designatin2", Forename = "Forename2", Surname = "Surname2" }, Course = new Course() { Description = "Test Course2", Name = "Test coursename2", Type = new CourseType() { Description = "Coursetype2", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator21" }, new CourseCoordinator() { Name = "Coordinator22" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook12", Type = new BookType() { Description = "BookType12", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook121" }, new AssociatedBooks() { Description = "AssociatedBook122" } } } } } },
											new Student() { Fullname = "Test Student3", Instructor = new Instructor() { Designation = "Designatin3", Forename = "Forename3", Surname = "Surname3" }, Course = new Course() { Description = "Test Course3", Name = "Test coursename3", Type = new CourseType() { Description = "Coursetype3", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator31" }, new CourseCoordinator() { Name = "Coordinator32" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook13", Type = new BookType() { Description = "BookType13", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook131" }, new AssociatedBooks() { Description = "AssociatedBook132" } } } } } },
											new Student() { Fullname = "Test Student4", Instructor = new Instructor() { Designation = "Designatin4", Forename = "Forename4", Surname = "Surname4" }, Course = new Course() { Description = "Test Course4", Name = "Test coursename4", Type = new CourseType() { Description = "Coursetype4", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator41" }, new CourseCoordinator() { Name = "Coordinator42" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook14", Type = new BookType() { Description = "BookType14", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook141" }, new AssociatedBooks() { Description = "AssociatedBook142" } } } } } },
											new Student() { Fullname = "Test Student5", Instructor = new Instructor() { Designation = "Designatin5", Forename = "Forename5", Surname = "Surname5" }, Course = new Course() { Description = "Test Course5", Name = "Test coursename5", Type = new CourseType() { Description = "Coursetype5", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator51" }, new CourseCoordinator() { Name = "Coordinator52" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook15", Type = new BookType() { Description = "BookType15", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook151" }, new AssociatedBooks() { Description = "AssociatedBook152" } } } } } },
											new Student() { Fullname = "Test Student6", Instructor = new Instructor() { Designation = "Designatin6", Forename = "Forename6", Surname = "Surname6" }, Course = new Course() { Description = "Test Course6", Name = "Test coursename6", Type = new CourseType() { Description = "Coursetype6", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator61" }, new CourseCoordinator() { Name = "Coordinator62" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook16", Type = new BookType() { Description = "BookType16", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook161" }, new AssociatedBooks() { Description = "AssociatedBook162" } } } } } },
											new Student() { Fullname = "Test Student7", Instructor = new Instructor() { Designation = "Designatin7", Forename = "Forename7", Surname = "Surname7" }, Course = new Course() { Description = "Test Course7", Name = "Test coursename7", Type = new CourseType() { Description = "Coursetype7", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator71" }, new CourseCoordinator() { Name = "Coordinator72" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook17", Type = new BookType() { Description = "BookType17", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook171" }, new AssociatedBooks() { Description = "AssociatedBook172" } } } } } },
											new Student() { Fullname = "Test Student8", Instructor = new Instructor() { Designation = "Designatin8", Forename = "Forename8", Surname = "Surname8" }, Course = new Course() { Description = "Test Course8", Name = "Test coursename8", Type = new CourseType() { Description = "Coursetype8", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator81" }, new CourseCoordinator() { Name = "Coordinator82" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook18", Type = new BookType() { Description = "BookType18", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook181" }, new AssociatedBooks() { Description = "AssociatedBook182" } } } } } },
											new Student() { Fullname = "Test Student9", Instructor = new Instructor() { Designation = "Designatin9", Forename = "Forename9", Surname = "Surname9" }, Course = new Course() { Description = "Test Course9", Name = "Test coursename9", Type = new CourseType() { Description = "Coursetype9", CourseCoordinators = new List<CourseCoordinator>() { new CourseCoordinator() { Name = "Coordinator91" }, new CourseCoordinator() { Name = "Coordinator92" } } } }, Books = new List<CourseBook>() { new CourseBook() { Description = "CourseBook19", Type = new BookType() { Description = "BookType19", AssociatedBooks = new List<AssociatedBooks>() { new AssociatedBooks() { Description = "AssociatedBook191" }, new AssociatedBooks() { Description = "AssociatedBook192" } } } } } }
											);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
