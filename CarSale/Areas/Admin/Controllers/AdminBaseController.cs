using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CarSale.Core.Constants.RoleConstants;

namespace CarSale.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {

    }
}
