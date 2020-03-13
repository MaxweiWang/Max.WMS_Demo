using System.Data;
using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_CustomerServices : IBaseServices<Wms_Customer>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);

        (bool, string) Import(DataTable dt, long userId);
    }
}