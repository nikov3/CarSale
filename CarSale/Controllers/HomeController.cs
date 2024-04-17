using CarSale.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarSale.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOfferService offerService;

        public HomeController(
            ILogger<HomeController> logger,
            IOfferService _offerService)
        {
            _logger = logger;
            offerService = _offerService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await offerService.LastThreeOffersAsync();

            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}
