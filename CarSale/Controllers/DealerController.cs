using CarSale.Core.Contracts;
using CarSale.Core.Models.Dealer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Become()
        {
            var model = new BecomeDealerFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeDealerFormModel model)
        {
            return RedirectToAction(nameof(OfferController.All), "Offer");
        }
    }
}
