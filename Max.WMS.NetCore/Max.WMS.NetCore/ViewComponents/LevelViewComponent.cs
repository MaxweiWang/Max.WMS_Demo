using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Max.Core.Utils.Extensions;
using Max.Core.Utils.Pub;

namespace Max.WMS.NetCore.ViewComponents
{
    public class LevelViewComponent : ViewComponent
    {
        public LevelViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = await EnumExt.ToKVListLinq<PubLevel>().ToAsync();
            return View(list);
        }
    }
}