using System;
using System.Linq.Expressions;
using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace IServices
{
    public interface IWms_storagerackServices : IBaseServices<Wms_storagerack>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}