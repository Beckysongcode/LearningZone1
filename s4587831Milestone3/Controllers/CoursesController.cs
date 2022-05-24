using LearningZone0.Data.Services;
using LearningZone0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using s4587831Milestone3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCourses = await _service.GetAllAsync(n => n.Difficulty);
            return View(allCourses);
        }

        //GET: Courses/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var courseDetail = await _service.GetCourseByIdAsync(id);
            return View(courseDetail);
        }

        //GET: Courses/Create
        public async Task<IActionResult> Create()
        {
            var courseDropdownsData = await _service.GetNewCourseDropdownsValues();

            ViewBag.Difficulties = new SelectList(courseDropdownsData.Difficulties, "Id", "Name");
            ViewBag.Convenors = new SelectList(courseDropdownsData.Convenors, "Id", "FullName");
            ViewBag.Teachers = new SelectList(courseDropdownsData.Teachers, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewCourseVM course)
        {
            if (!ModelState.IsValid)
            {
                var courseDropdownsData = await _service.GetNewCourseDropdownsValues();

                ViewBag.Difficulties = new SelectList(courseDropdownsData.Difficulties, "Id", "Name");
                ViewBag.Convenors = new SelectList(courseDropdownsData.Convenors, "Id", "FullName");
                ViewBag.Teachers = new SelectList(courseDropdownsData.Teachers, "Id", "FullName");

                return View(course);
            }

            await _service.AddNewCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }
    }
}
