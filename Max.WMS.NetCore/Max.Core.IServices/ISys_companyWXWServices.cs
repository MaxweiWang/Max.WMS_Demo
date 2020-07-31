using Max.Core.Entity;
using Max.Core.Utils.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Max.Core.IServices
{
    public interface ISys_companyWXWServices : IBaseServices<Sys_companyWXW>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}
