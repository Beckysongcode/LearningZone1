using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone1.Models
{
    public class Teacher_Course
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
