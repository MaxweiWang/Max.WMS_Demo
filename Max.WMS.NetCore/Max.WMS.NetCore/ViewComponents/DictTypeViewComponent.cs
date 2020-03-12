using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Max.Core.Utils.Extensions;
using Max.Core.Utils.Pub;

namespace Max.WMS.NetCore.ViewComponents
{
    public class DictTypeViewComponent : ViewComponent
    {
        public DictTypeViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = await EnumExt.ToKVListLinq<PubDictType>().ToAsync();
            return View(list);
        }
    }
}