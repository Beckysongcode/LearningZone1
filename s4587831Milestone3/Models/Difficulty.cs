using s4587831Milestone3.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Models
{
    public class Difficulty : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Difficulty Bar")]
        [Required(ErrorMessage = "Difficulty logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Difficulty Level")]
        [Required(ErrorMessage = "Difficulty level name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Difficulty description is required")]
        public string Description { get; set; }

        //Relationships
#nullable disable
        public List<Course> Courses { get; set; }
    }
}
