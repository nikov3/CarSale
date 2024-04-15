﻿using CarSale.Attributes;
using CarSale.Core.Contracts;
using CarSale.Core.Extensions;
using CarSale.Core.Models.Offer;
using CarSale.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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
        public async Task<IActionResult> All([FromQuery]AllOffersQueryModel query) 
        {
            var model = await offerService.AllAsync(
                query.Brand,
                query.CarModel,
                query.Fuel,
                query.Transmission,
                query.CarType,
                query.Color,
                query.City,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.OffersPerPage);

            query.TotalOffersCount = model.TotalOffersCount;
            query.Offers = model.Offers;
            query.Brands = await offerService.AllBrandsNamesAsync();
            query.Fuels = await offerService.AllFuelsNamesAsync();
            query.Transmissions = await offerService.AllTransmissionsNamesAsync();
            query.CarTypes = await offerService.AllCarTypesNamesAsync();
            query.Colors = await offerService.AllColorsNamesAsync();
            query.Cities = await offerService.AllCitiesNamesAsync();

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            IEnumerable<OfferServiceModel> model = null;

            if(await dealerService.ExistsByIdAsync(userId))
            {
                int dealerId = await dealerService.GetDealerIdAsync(userId) ?? 0;
                model = await offerService.AllOffersByDealerIdAsync(dealerId);
            }
            else
            {
                return Unauthorized();
            }
            //fix if needed(my offers in tab, should be visible by dealer an not user)

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, string information)
        {
            if(await offerService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await offerService.OfferDetailsByIdAsync(id);

            if (information != model.GetInformation())
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpGet]
        [MustBeADealer]
        public async Task<IActionResult> Add() 
        {
            var model = new OfferFormModel()
            {
                Brands = await offerService.AllBrandsAsync(),
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
                ModelState.AddModelError(nameof(model.BrandId), "Brand does not exist");
            }
            
            if (await offerService.CarTypeExistsAsync(model.CarTypeId) == false)
            {
                ModelState.AddModelError(nameof(model.CarTypeId), "Car type does not exist");
            }
            
            if (await offerService.CityExistsAsync(model.CityId) == false)
            {
                ModelState.AddModelError(nameof(model.CityId), "City does not exist");
            }
            
            if (await offerService.ColorsExistsAsync(model.ColorId) == false)
            {
                ModelState.AddModelError(nameof(model.ColorId), "Color does not exist");
            }
            
            if (await offerService.TransmissionExistsAsync(model.TransmissionId) == false)
            {
                ModelState.AddModelError(nameof(model.TransmissionId), "Transmission does not exist");
            }
            
            if (await offerService.FuelExistsAsync(model.FuelId) == false)
            {
                ModelState.AddModelError(nameof(model.FuelId), "Fuel does not exist");
            }


            if (ModelState.IsValid == false)
            {
                model.Brands = await offerService.AllBrandsAsync();
                model.Fuels = await offerService.AllFuelsAsync();
                model.Colors = await offerService.AllColorsAsync();
                model.Cities = await offerService.AllCitiesAsync();
                model.CarTypes = await offerService.AllCarTypesAsync();
                model.Transmissions = await offerService.AllTransmissionsAsync();

                return View(model);
            }
            
            int? dealerId = await dealerService.GetDealerIdAsync(User.Id());

            int newOfferId = await offerService.CreateAsync(model, dealerId ?? 0);

            return RedirectToAction(nameof(Details), new { id = newOfferId, Information = model.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if(await offerService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if(await offerService.HasDealerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var model = await offerService.GetOfferFormModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, OfferFormModel model)
        {
            if (await offerService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await offerService.HasDealerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            if (await offerService.BrandExistsAsync(model.BrandId) == false)
            {
                ModelState.AddModelError(nameof(model.BrandId), "Brand does not exist");
            }

            if (await offerService.CarTypeExistsAsync(model.CarTypeId) == false)
            {
                ModelState.AddModelError(nameof(model.CarTypeId), "Car type does not exist");
            }

            if (await offerService.CityExistsAsync(model.CityId) == false)
            {
                ModelState.AddModelError(nameof(model.CityId), "City does not exist");
            }

            if (await offerService.ColorsExistsAsync(model.ColorId) == false)
            {
                ModelState.AddModelError(nameof(model.ColorId), "Color does not exist");
            }

            if (await offerService.TransmissionExistsAsync(model.TransmissionId) == false)
            {
                ModelState.AddModelError(nameof(model.TransmissionId), "Transmission does not exist");
            }

            if (await offerService.FuelExistsAsync(model.FuelId) == false)
            {
                ModelState.AddModelError(nameof(model.FuelId), "Fuel does not exist");
            }


            if (ModelState.IsValid == false)
            {
                model.Brands = await offerService.AllBrandsAsync();
                model.Fuels = await offerService.AllFuelsAsync();
                model.Colors = await offerService.AllColorsAsync();
                model.Cities = await offerService.AllCitiesAsync();
                model.CarTypes = await offerService.AllCarTypesAsync();
                model.Transmissions = await offerService.AllTransmissionsAsync();

                return View(model);
            }

            await offerService.EditAsync(id, model);

            return RedirectToAction(nameof(Details), new { id, Information = model.GetInformation()});
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await offerService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await offerService.HasDealerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var offer = await offerService.OfferDetailsByIdAsync(id);

            var model = new OfferDetailsViewModel()
            {
                Id = id,
                CarModel = offer.CarModel,
                Description = offer.Description,
                ImageUrl = offer.ImageUrl,
                Title = offer.Brand + " " + offer.CarModel
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(OfferDetailsViewModel model)
        {
            if (await offerService.ExistsAsync(model.Id) == false)
            {
                return BadRequest();
            }

            if (await offerService.HasDealerWithIdAsync(model.Id, User.Id()) == false)
            {
                return Unauthorized();
            }

            await offerService.DeleteAsync(model.Id);

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
