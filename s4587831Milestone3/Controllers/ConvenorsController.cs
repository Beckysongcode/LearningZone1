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
    public class ConvenorsController : Controller
    {
        private readonly IConvenorsService _service;

        public ConvenorsController(IConvenorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allConvenors = await _service.GetAllAsync();
            return View(allConvenors);
        }

        //GET: convenors/details/1
        public async Task<IActionResult> Details(int id)
        {
            var convenorDetails = await _service.GetByIdAsync(id);
            if (convenorDetails == null) return View("NotFound");
            return View(convenorDetails);
        }

        //GET: convenors/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Convenor convenor)
        {
            if (!ModelState.IsValid) return View(convenor);

            await _service.AddAsync(convenor);
            return RedirectToAction(nameof(Index));
        }

        //GET: convenors/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var convenorDetails = await _service.GetByIdAsync(id);
            if (convenorDetails == null) return View("NotFound");
            return View(convenorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Convenor convenor)
        {
            if (!ModelState.IsValid) return View(convenor);

            if (id == convenor.Id)
            {
                await _service.UpdateAsync(id, convenor);
                return RedirectToAction(nameof(Index));
            }
            return View(convenor);
        }

        //GET: convenors/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var convenorDetails = await _service.GetByIdAsync(id);
            if (convenorDetails == null) return View("NotFound");
            return View(convenorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var convenorDetails = await _service.GetByIdAsync(id);
            if (convenorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
