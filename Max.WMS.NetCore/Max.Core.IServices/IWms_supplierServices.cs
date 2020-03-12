using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace IServices
{
    public interface IWms_supplierServices : IBaseServices<Wms_supplier>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}
