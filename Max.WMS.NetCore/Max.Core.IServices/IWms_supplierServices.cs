using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_supplierServices : IBaseServices<Wms_supplier>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}
