using CarSale.Attributes;
using CarSale.Core.Contracts;
using CarSale.Core.Models.Dealer;
using CarSale.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CarSale.Core.Constants.MessageConstants;

namespace CarSale.Controllers
{
    public class DealerController : BaseController
    {
        private readonly IDealerService dealerService;

        public DealerController(IDealerService _dealerService)
        {
            dealerService = _dealerService;
        }

        [HttpGet]
        [NotADealer]
        public IActionResult Become()
        {

            var model = new BecomeDealerFormModel();

            return View(model);
        }

        [HttpPost]
        [NotADealer]
        public async Task<IActionResult> Become(BecomeDealerFormModel model)
        {
            if(await dealerService.UserWithPhoneNumberExistsAsync(User.Id()))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExists);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await dealerService.CreateAsync(User.Id(), model.PhoneNumber);

            return RedirectToAction(nameof(OfferController.All), "Offer");
        }
    }
}
