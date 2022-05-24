using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s4587831Milestone3.Data;
using s4587831Milestone3.Data.Services;
using s4587831Milestone3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Controllers
{
    public class DifficultiesController : Controller
    {
        private readonly IDifficultiesService _service;
        public DifficultiesController(IDifficultiesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allDifficulties = await _service.GetAllAsync();
            return View(allDifficulties);
        }

        //Get: Difficulties/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Difficulty difficulty)
        {
            if (!ModelState.IsValid) return View(difficulty);
            await _service.AddAsync(difficulty);
            return RedirectToAction(nameof(Index));

        }

        //Get: Difficulties/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var difficultyDetail = await _service.GetByIdAsync(id);
            if (difficultyDetail == null) return View("NotFound");
            return View(difficultyDetail);
        }

        //Get: Difficulties/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var difficultyDetail = await _service.GetByIdAsync(id);
            if (difficultyDetail == null) return View("NotFound");
            return View(difficultyDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Difficulty difficulty)
        {
            if (!ModelState.IsValid) return View(difficulty);
            await _service.UpdateAsync(id, difficulty);
            return RedirectToAction(nameof(Index));

        }

        //Get: Difficulties/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var difficultyDetail = await _service.GetByIdAsync(id);
            if (difficultyDetail == null) return View("NotFound");
            return View(difficultyDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var difficultyDetail = await _service.GetByIdAsync(id);
            if (difficultyDetail == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }


    }
}
