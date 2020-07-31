using Max.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using System.Linq;
using Max.Core.Entity;
using Max.Core.Entity.Fluent.Validation;
using Max.NetCore.DIExtensions.Attributes;
using Max.NetCore.DIExtensions;
using Max.Core.Utils.Extensions;
using Max.Core.Utils.Pub;
using Max.Core.Utils.Table;
using Max.WMS.NetCore.Attributes;

namespace Max.WMS.NetCore.Controllers
{
    public class CompanyWXWController : BaseController
    {
        private readonly ISys_companyWXWServices _companyServices;

        public CompanyWXWController(ISys_companyWXWServices companyServices)
        {
            _companyServices = companyServices;
        }

        [HttpGet]
        [CheckMenu]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [OperationLog(LogType = LogType.select)]
        public ContentResult List([FromForm]Bootstrap.BootstrapParams bootstrap)
        {
            var sd = _companyServices.PageList(bootstrap);
            return Content(sd);
        }

        [HttpGet]
        public IActionResult Add(string id)
        {
            Sys_companyWXW company = new Sys_companyWXW();
            if (id.IsEmpty())
            {
                return View(company);
            }
            else
            {
                company = _companyServices.QueryableToEntity(c => c.CompanyWXWId == SqlFunc.ToInt64(id));
                return View(company);
            }
        }

        [HttpPost]
        [FilterXss]
        [OperationLog(LogType = LogType.addOrUpdate)]
        public IActionResult AddOrUpdate([FromForm]Sys_companyWXW company, [FromForm]string id)
        {
            var validator = new SysCompanyWXWFluent();
            var results = validator.Validate(company);
            var success = results.IsValid;
            if (!success)
            {
                string msg = results.Errors.Aggregate("", (current, item) => (item.ErrorMessage + "</br>"));
                //foreach (var item in results.Errors)
                //{
                //    msg += item.ErrorMessage + "</br>";
                //}
                return BootJsonH((PubEnum.Failed.ToInt32(), msg));
            }
            if (id.IsEmptyZero())
            {
                if (_companyServices.IsAny(c => c.CompanyWXWNo == company.CompanyWXWNo))
                {
                    return BootJsonH((false, PubConst.Dept2));
                }
                company.CompanyWXWId = PubId.SnowflakeId;
                company.CreateBy = UserDtoCache.UserId;
                bool flag = _companyServices.Insert(company);
                return BootJsonH(flag ? (flag, PubConst.Add1) : (flag, PubConst.Add2));
            }
            else
            {
                company.CompanyWXWId = id.ToInt64();
                company.ModifiedBy = UserDtoCache.UserId;
                company.ModifiedDate = DateTimeExt.DateTime;
                var flag = _companyServices.Update(company);
                return BootJsonH(flag ? (flag, PubConst.Update1) : (flag, PubConst.Update2));
            }
        }

        [HttpGet]
        [OperationLog(LogType.delete)]
        public IActionResult Delete(string id)
        {
            //var flag = _companyServices.Delete(c => c.DeptId == SqlFunc.ToInt64(id));
            var flag = _companyServices.Update(new Sys_companyWXW { CompanyWXWId = SqlFunc.ToInt64(id), IsDel = 0, ModifiedBy = UserDtoCache.UserId, ModifiedDate = DateTimeExt.DateTime }, c => new { c.IsDel, c.ModifiedBy, c.ModifiedDate });
            return BootJsonH(flag ? (flag, PubConst.Delete1) : (flag, PubConst.Delete2));
        }
    }
}