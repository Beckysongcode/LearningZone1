using LearningZone1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone1.Data.ViewModels
{
    public class NewCourseDropdownsVM
    {
        public NewCourseDropdownsVM()
        {
            Convenors = new List<Convenor>();
            Difficulties = new List<Difficulty>();
            Teachers = new List<Teacher>();
        }

        public List<Convenor> Convenors { get; set; }   
        public List<Difficulty> Difficulties { get; set; }  
        public List<Teacher> Teachers { get; set; }   
    }
}
