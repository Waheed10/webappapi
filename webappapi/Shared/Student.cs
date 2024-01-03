using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webappapi.Shared
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        // Foreign key for Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

    // SharedModels/Course.cs
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
    }

}
