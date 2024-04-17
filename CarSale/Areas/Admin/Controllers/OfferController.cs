using CarSale.Core.Contracts;
using CarSale.Core.Models.Admin;
using CarSale.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CarSale.Areas.Admin.Controllers
{
    public class OfferController : AdminBaseController
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

        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            int dealerId = await dealerService.GetDealerIdAsync(userId) ?? 0;
            var myOffers = new MyOffersViewModel()
            {
                AddedOffers = await offerService.AllOffersByDealerIdAsync(dealerId)
            };

            return View(myOffers);
        }

        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var model = await offerService.GetUnApprovedAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int offerId)
        {
            await offerService.ApproveOfferAsync(offerId);

            return RedirectToAction(nameof(Approve));
        }
    }
}
