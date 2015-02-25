using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4EF6LazyLoadDemo.Models
{
	public class Student
	{
		public int Id { get; set; }
		public int CourseId { get; set; }
		public int InstructorId { get; set; }
		public string Fullname { get; set; }
		public virtual ICollection<CourseBook> Books { get; set; }
		public virtual Course Course { get; set; }
		public virtual Instructor Instructor { get; set; }


	}

	public class CourseBook
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public BookType Type { get; set; }

	}

	public class BookType
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public ICollection<AssociatedBooks> AssociatedBooks { get; set; } 
	}

	public class AssociatedBooks
	{
		public int Id { get; set; }
		public string Description { get; set; }
	}

	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public CourseType Type { get; set; }
	}

	public class CourseType
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public List<CourseCoordinator> CourseCoordinators { get; set; } 
	}

	public class CourseCoordinator
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Instructor
	{
		public int Id { get; set; }
		public string Forename { get; set; }
		public string Surname { get; set; }
		public string Designation { get; set; }

		
	}
}