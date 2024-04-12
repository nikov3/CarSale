using CarSale.Attributes;
using CarSale.Core.Contracts;
using CarSale.Core.Models.Offer;
using CarSale.Data.Models;
using CarSale.Extensions;
using CarSale.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarSale.Controllers
{
    public class OfferController : BaseController
    {
        private readonly IOfferService offerService;

        private readonly IDealerService dealerService;

        public OfferController(
            IOfferService _offerService,
            IDealerService _dealerService)
        {
            offerService = _offerService;
            dealerService = _dealerService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllOffersQueryModel query) 
        {
            var model = new AllOffersQueryModel();

            return View(query);
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
        [MustBeADealer]
        public async Task<IActionResult> Add() 
        {
            var model = new OfferFormModel()
            {
                Brands = await offerService.AllBrandsAsync(),
                CarModels = await offerService.AllCarModelsAsync(),
                Fuels = await offerService.AllFuelsAsync(),
                Transmissions = await offerService.AllTransmissionsAsync(),
                CarTypes = await offerService.AllCarTypesAsync(),
                Colors = await offerService.AllColorsAsync(),
                Cities = await offerService.AllCitiesAsync(),
            };

            return View(model);
        }

        [HttpPost]
        [MustBeADealer]
        public async Task<IActionResult> Add(OfferFormModel model)
        {
            if (await offerService.BrandExistsAsync(model.BrandId) == false)
            {
                ModelState.AddModelError(nameof(model.BrandId), "");
            }

            if (await offerService.CarModelExistsAsync(model.CarModelId) == false)
            {
                ModelState.AddModelError(nameof(model.CarModelId), "");
            }
            
            if (await offerService.CarTypeExistsAsync(model.CarTypeId) == false)
            {
                ModelState.AddModelError(nameof(model.CarTypeId), "");
            }
            
            if (await offerService.CityExistsAsync(model.CityId) == false)
            {
                ModelState.AddModelError(nameof(model.CityId), "");
            }
            
            if (await offerService.ColorsExistsAsync(model.ColorId) == false)
            {
                ModelState.AddModelError(nameof(model.ColorId), "");
            }
            
            if (await offerService.TransmissionExistsAsync(model.TransmissionId) == false)
            {
                ModelState.AddModelError(nameof(model.TransmissionId), "");
            }
            
            if (await offerService.FuelExistsAsync(model.FuelId) == false)
            {
                ModelState.AddModelError(nameof(model.FuelId), "");
            }


            if (ModelState.IsValid == false)
            {
                model.Brands = await offerService.AllBrandsAsync();
                model.CarModels = await offerService.AllCarModelsAsync();
                model.Fuels = await offerService.AllFuelsAsync();
                model.Colors = await offerService.AllColorsAsync();
                model.Cities = await offerService.AllCitiesAsync();
                model.CarTypes = await offerService.AllCarTypesAsync();
                model.Transmissions = await offerService.AllTransmissionsAsync();

                return View(model);
            }

            int? dealerId = await dealerService.GetDealerIdAsync(User.Id());

            int newOfferId = await offerService.CreateAsync(model, dealerId ?? 0);

            return RedirectToAction(nameof(Details), new { id = newOfferId });
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




        //// GET: CarOfferController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: CarOfferController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: CarOfferController/Create
        //public async Task<ActionResult> Create()
        //{
        //    // Fetching the names of all CarBrands
        //    var brands = await _context.Brands
        //        .Select(c => new { c.Id, c.Name })
        //        .ToListAsync();

        //    var carModels = await _context.CarModels
        //        .Select(cm => new { cm.Id, cm.Name, cm.BrandId })
        //        .ToListAsync();

        //    var fuels = await _context.Fuels
        //        .Select(c => new { c.Id, c.Name })
        //        .ToListAsync();

        //    var transmissions = await _context.Transmissions
        //        .Select(c => new { c.Id, c.Name })
        //        .ToListAsync();

        //    // Creating a SelectList, setting "Id" as the value field and "Name" as the text field
        //    ViewBag.Brand = new SelectList(brands, "Id", "Name");
        //    ViewBag.CarModel = new SelectList(carModels, "Id", "Name");
        //    ViewBag.Fuel = new SelectList(fuels, "Id", "Name");
        //    ViewBag.Transmission = new SelectList(transmissions, "Id", "Name");
        //    return View();
        //}

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
