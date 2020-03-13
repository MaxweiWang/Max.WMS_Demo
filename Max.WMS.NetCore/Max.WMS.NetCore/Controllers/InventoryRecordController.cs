using Max.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using Max.Core.Dto;
using Max.NetCore.Extensions.Attributes;
using Max.NetCore.Extensions;
using Max.Core.Utils.Pub;
using Max.WMS.NetCore.Attributes;

namespace Max.WMS.NetCore.Controllers
{
    public class InventoryRecordController : BaseController
    {
        private readonly IWms_inventoryrecordServices _inventoryrecordServices;

        public InventoryRecordController(
            IWms_inventoryrecordServices inventoryrecordServices
            )
        {
            _inventoryrecordServices = inventoryrecordServices;
        }

        [HttpGet]
        [CheckMenu]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [OperationLog(LogType.select)]
        public ContentResult List([FromForm]PubParams.InventoryBootstrapParams bootstrap)
        {
            var sd = _inventoryrecordServices.PageList(bootstrap);
            return Content(sd);
        }
    }
}