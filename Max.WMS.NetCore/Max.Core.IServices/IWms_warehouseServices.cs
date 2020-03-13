using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_warehouseServices : IBaseServices<Wms_warehouse>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}