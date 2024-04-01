using CarSale.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarSale.Controllers
{
    public class OfferController : Controller
    {
        private readonly CarSaleDbContext _context;

        public OfferController(CarSaleDbContext context)
        {
            _context = context;
        }

        // GET: CarOfferController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarOfferController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarOfferController/Create
        public async Task<ActionResult> Create()
        {
            // Fetching the names of all CarBrands
            var brands = await _context.Brands
                .Select(c => new { c.Id, c.Name })
                .ToListAsync();

            var carModels = await _context.CarModels
                .Select(cm => new { cm.Id, cm.Name, cm.BrandId })
                .ToListAsync();

            var fuels = await _context.Fuels
                .Select(c => new { c.Id, c.Name })
                .ToListAsync();

            var transmissions = await _context.Transmissions
                .Select(c => new { c.Id, c.Name })
                .ToListAsync();

            // Creating a SelectList, setting "Id" as the value field and "Name" as the text field
            ViewBag.Brand = new SelectList(brands, "Id", "Name");
            ViewBag.CarModel = new SelectList(carModels, "Id", "Name");
            ViewBag.Fuel = new SelectList(fuels, "Id", "Name");
            ViewBag.Transmission = new SelectList(transmissions, "Id", "Name");
            return View();
        }

        // POST: CarOfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarOfferController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarOfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarOfferController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarOfferController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
