using CarSale.Controllers;
using CarSale.Core.Contracts;
using CarSale.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarSale.Attributes
{
    public class MustBeADealer : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IDealerService? dealerService = context.HttpContext.RequestServices.GetService<IDealerService>();

            if (dealerService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (dealerService != null
                && dealerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result == false)
            {
                context.Result = new RedirectToActionResult(nameof(DealerController), "Dealer", null);
            }
        }
    }
}
