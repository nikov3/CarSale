using CarSale.Core.Contracts;
using CarSale.Core.Models.Home;
using CarSale.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarSale.Controllers
{
    public class HomeController : Controller
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

        public async Task<IActionResult> Index()
        {
            var model = await offerService.LastThreeOffers();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
