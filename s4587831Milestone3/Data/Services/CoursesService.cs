using LearningZone0.Data.ViewModels;
using LearningZone0.Models;
using Microsoft.EntityFrameworkCore;
using s4587831Milestone3.Data;
using s4587831Milestone3.Data.Base;
using s4587831Milestone3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone0.Data.Services
{
    public class CoursesService:EntityBaseRepository<Course>, ICoursesService
    {
        private readonly AppDbContext _context;
        public CoursesService(AppDbContext context):base(context)
        {
            _context = context;
        }

        public async Task AddNewCourseAsync(NewCourseVM data)
        {
            var newCourse = new Course()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                DifficultyId = data.DifficultyId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                CourseSubject = data.CourseSubject,
                ConvenorId = data.ConvenorId
            };
            await _context.Courses.AddAsync(newCourse);
            await _context.SaveChangesAsync();

            //Add Course Teachers
            foreach (var teacherId in data.TeacherIds)
            {
                var newTeacherCourse = new Teacher_Course()
                {
                    CourseId = newCourse.Id,
                    TeacherId = teacherId
                };
                await _context.Teachers_Courses.AddAsync(newTeacherCourse);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var courseDetails = await _context.Courses
                .Include(d => d.Difficulty)
                .Include(c => c.Convenor)
                .Include(tc => tc.Teachers_Courses).ThenInclude(t => t.Teacher)
                .FirstOrDefaultAsync(n => n.Id == id);

            return courseDetails;
        }

        public async Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues()
        {
            var response = new NewCourseDropdownsVM()
            {
                Teachers = await _context.Teachers.OrderBy(n => n.FullName).ToListAsync(),
                Difficulties = await _context.Difficulties.OrderBy(n => n.Name).ToListAsync(),
                Convenors = await _context.Convenors.OrderBy(n => n.FullName).ToListAsync()
            };


            return response;
        }
    }
}
