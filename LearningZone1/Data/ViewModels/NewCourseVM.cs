using LearningZone1.Data;
using LearningZone1.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone1.Models
{
    public class NewCourseVM
    {
        public int Id { get; set; }

        [Display(Name = "Course name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Course description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Course image URL")]
        [Required(ErrorMessage = "Course image is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Course start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Course end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a subject")]
        [Required(ErrorMessage = "Course subject is required")]
        public CourseSubject CourseSubject { get; set; }

        //Relationships
        [Display(Name = "Select teacher(s)")]
        [Required(ErrorMessage = "Course teacher(s) is required")]
        public List<int> TeacherIds { get; set; }

        [Display(Name = "Select a difficulty")]
        [Required(ErrorMessage = "Course difficulty is required")]
        public int DifficultyId { get; set; }

        [Display(Name = "Select a convenor)")]
        [Required(ErrorMessage = "Course convenor(s) is required")]
        public int ConvenorId { get; set; }
       
    }
}
