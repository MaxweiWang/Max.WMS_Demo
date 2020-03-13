using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Max.Core.Entity;
using Max.Core.Utils.Env;
using Max.Core.IServices;
using Max.NetCore.Extensions.DI;
using Microsoft.Extensions.DependencyInjection;
using Max.Core.Utils.Log;

namespace Max.WMS.NetCore
{
    public class SysLogNotification : INotificationHandler<Sys_log>
    {
        public Task Handle(Sys_log notification, CancellationToken cancellationToken)
        {
            var _log = GlobalCore.GetRequiredService<ISys_logServices>();
            //var _log = ServiceResolve.Resolve<ISys_logServices>();
            _log.Insert(notification);
            return Task.CompletedTask;
        }
    }
}