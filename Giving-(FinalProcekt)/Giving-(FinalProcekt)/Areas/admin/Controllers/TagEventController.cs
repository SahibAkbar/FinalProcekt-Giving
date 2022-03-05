using Giving__FinalProcekt_.Data;
using Giving__FinalProcekt_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giving__FinalProcekt_.Areas.admin.Controllers
{
    [Area("Admin")]
    public class TagEventController : Controller
    {
        private readonly AppDbContext _context;

        public TagEventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<TagEvent> model = _context.TagEvents.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TagEvent model)
        {
            if (ModelState.IsValid)
            {
                _context.TagEvents.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);

        }
        public IActionResult Update(int id)
        {
            return View(_context.TagEvents.Find(id));
        }

        [HttpPost]
        public IActionResult Update(TagEvent model)
        {
            if (ModelState.IsValid)
            {
                _context.TagEvents.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TagEvent tag = _context.TagEvents.Find(id);
            _context.TagEvents.Remove(tag);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
