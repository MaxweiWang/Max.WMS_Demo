﻿using Max.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Security.Claims;
using Max.Core.Utils.Extensions;
using Max.Core.Utils.Pub;

namespace Max.WMS.NetCore.Attributes
{
    public class CheckMenuAttribute : ActionFilterAttribute
    {
        public CheckMenuAttribute()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var viewData = (context.Controller as Controller)?.ViewData;
            var viewBag = (context.Controller as Controller)?.ViewBag;
            var services = context.HttpContext.RequestServices;
            //var log = services.GetService(typeof(ILoggerFactory)) as ILoggerFactory;
            //ILogger<CheckMenuAttribute> logger = log.CreateLogger<CheckMenuAttribute>();
            //logger.LogInformation("");

            var properties = context.ActionDescriptor.Properties;
            var claims = context.HttpContext.User?.Claims;
            var cache = services.GetService(typeof(IMemoryCache)) as IMemoryCache;
            var roleServices = services.GetService(typeof(ISys_roleServices)) as ISys_roleServices;
            if (viewData != null)
            {
                if (context.HttpContext.User != null)
                {
                    var UserId = claims.SingleOrDefault(c => c.Type == ClaimTypes.Sid).Value;
                    viewData["menu"] = cache.Get("menu_" + UserId) ?? roleServices?.GetMenu(claims.SingleOrDefault(c => c.Type == ClaimTypes.Role).Value.ToInt64());
                }
                // ReSharper disable once PossibleNullReferenceException
            }
            if (viewBag != null)
            {
                viewBag.title = properties["title"].ToString();
                viewBag.company = properties["company"].ToString();
                viewBag.customer = properties["customer"].ToString();
                viewBag.nickname = claims.SingleOrDefault(c => c.Type == ClaimTypes.Name).Value;
                viewBag.headimg = claims.SingleOrDefault(c => c.Type == ClaimTypes.Uri).Value;
            }
            base.OnActionExecuting(context);
        }
    }
}