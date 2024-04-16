using Microsoft.AspNetCore.Mvc;

namespace CarSale.Areas.Admin.Components
{
    public class AdminMenuComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
