using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_CarrierServices: IBaseServices<Wms_Carrier>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}
