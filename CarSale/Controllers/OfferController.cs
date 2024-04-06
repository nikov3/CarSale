using CarSale.Core.Models.Offer;
using CarSale.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarSale.Controllers
{
    public class OfferController : BaseController
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All() 
        {
            var model = new AllOffersQueryModel();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var model = new AllOffersQueryModel();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = new OfferDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(OfferFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = 1 });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new OfferFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, OfferFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = 1 });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new OfferDetailsViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(OfferDetailsViewModel model)
        {
            return RedirectToAction(nameof(All));
        }





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

        //// GET: CarOfferController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

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

        //// POST: CarOfferController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: CarOfferController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: CarOfferController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: CarOfferController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: CarOfferController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
