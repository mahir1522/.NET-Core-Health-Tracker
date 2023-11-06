using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPatel5655.Models;

namespace MPatel5655.Controllers
{
    public class MeasurementController : Controller
    {
        private MeasurementContext _context { get; set; }

        public MeasurementController(MeasurementContext ctx) => _context = ctx;

        public IActionResult AllMeasurement()
        {
            var measurements = _context.Measurements.Include(m => m.Position).ToList();
            return View(measurements);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Positions = _context.Positions.OrderBy(g => g.Name).ToList();
            return View("Edit", new Measurement());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Positions = _context.Positions.OrderBy(g => g.Name).ToList();
            var measurement = _context.Measurements.Find(id);
            return View(measurement);
        }
        [HttpPost]
        public IActionResult Edit(Measurement measurement)
        {
            if (ModelState.IsValid)
            {
                if (measurement.Id == 0)
                    _context.Measurements.Add(measurement);
                else
                    _context.Measurements.Update(measurement);
                _context.SaveChanges();
                return RedirectToAction("AllMeasurement", "Measurement");
            }
            else
            {
                ViewBag.Action = (measurement.Id == 0) ? "Add" : "Edit";
                ViewBag.Positions = _context.Positions.OrderBy(g => g.Name).ToList();
                return View(measurement);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var measurement = _context.Measurements.Find(id);
            return View(measurement);
        }
        [HttpPost]
        public IActionResult Delete(Measurement measurement)
        {
            _context.Measurements.Remove(measurement);
            _context.SaveChanges();
            return RedirectToAction("AllMeasurement", "Measurement");

        }
    }
}
