using LearningZone1.Data.Base;
using LearningZone1.Data.ViewModels;
using LearningZone1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone1.Data.Services
{
    public interface ICoursesService:IEntityBaseRepository<Course>
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues();
        Task AddNewCourseAsync(NewCourseVM data);
        Task UpdateCourseAsync(NewCourseVM data);
    }
}
