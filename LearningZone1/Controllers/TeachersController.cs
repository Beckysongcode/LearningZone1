using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningZone1.Data;
using LearningZone1.Data.Services;
using LearningZone1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningZone1.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeachersService _service;

        public TeachersController(ITeachersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();  
            return View(data);
        }

        //Get: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }
            await _service.AddAsync(teacher);
            return RedirectToAction(nameof(Index));
        }

        //Get: Teachers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);

            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        //Get: Teachers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }
            await _service.UpdateAsync(id, teacher);
            return RedirectToAction(nameof(Index));
        }

        //Get: Teachers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
