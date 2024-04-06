using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarSale.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
