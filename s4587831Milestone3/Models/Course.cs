using s4587831Milestone3.Data;
using s4587831Milestone3.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Models
{
    public class Course:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CourseSubject CourseSubject { get; set; }

        //Relationships
        public List<Teacher_Course> Teachers_Courses { get; set; }

        //Difficulty
        public int DifficultyId { get; set; }
        [ForeignKey("DifficultyId")]
        public Difficulty Difficulty { get; set; }

        //Convenor
        public int ConvenorId { get; set; }
        [ForeignKey("ConvenorId")]
        public Convenor Convenor { get; set; }
    }
}
