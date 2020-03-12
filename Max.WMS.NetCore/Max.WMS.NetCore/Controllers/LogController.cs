using IServices;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using System.Linq;
using Max.NetCore.Extensions.Attributes;
using Max.NetCore.Extensions.NetCoreApp;
using Max.Core.Utils.Pub;
using Max.Core.Utils.Table;

namespace Max.WMS.NetCore.Controllers
{
    public class LogController : BaseController
    {
        private readonly ISys_logServices _logServices;
        private readonly SqlSugarClient _client;

        public LogController(SqlSugarClient client, ISys_logServices logServices)
        {
            _client = client;
            _logServices = logServices;
        }

        [HttpGet]
        [CheckMenu]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ContentResult List([FromForm]Bootstrap.BootstrapParams bootstrap)
        {
            var sd = _logServices.PageList(bootstrap);
            return Content(sd);
        }

        //[HttpDelete] axios
        //'Content-Type': 'application/json; charset=UTF-8' FromBody 修饰的每个操作，最多可以有一个参数
        [HttpPost]
        public IActionResult Delete([FromBody]long[] Id)
        {
            var flag = _logServices.Delete(Id.ToArray());
            return BootJsonH(flag ? (flag, PubConst.Delete1) : (flag, PubConst.Delete2));
        }

        [HttpGet]
        [CheckMenu]
        public IActionResult Bar()
        {
            return View();
        }

        [HttpPost]
        [OperationLog(LogType.select)]
        public ContentResult Bar([FromForm]Bootstrap.BootstrapParams bootstrap)
        {
            var str = _logServices.EChart(bootstrap);
            return Content(str);
        }
    }
}