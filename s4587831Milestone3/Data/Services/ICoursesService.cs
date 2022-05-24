using LearningZone0.Data.ViewModels;
using LearningZone0.Models;
using s4587831Milestone3.Data.Base;
using s4587831Milestone3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone0.Data.Services
{
    public interface ICoursesService:IEntityBaseRepository<Course>
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues();
        Task AddNewCourseAsync(NewCourseVM data);
    }
}
