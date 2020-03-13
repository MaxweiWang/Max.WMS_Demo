using Max.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Max.Core.Utils.Extensions;

namespace Max.WMS.NetCore.ViewComponents
{
    public class WarehouseViewComponent : ViewComponent
    {
        private readonly IWms_warehouseServices _warehouseServices;

        public WarehouseViewComponent(IWms_warehouseServices warehouseServices)
        {
            _warehouseServices = warehouseServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _warehouseServices.QueryableToList(c => c.IsDel == 1).ToListAsync();
            return View(model);
        }
    }
}