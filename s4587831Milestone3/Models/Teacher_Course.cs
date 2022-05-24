using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Models
{
    public class Teacher_Course
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
