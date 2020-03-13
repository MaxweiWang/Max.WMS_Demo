using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_reservoirareaServices : IBaseServices<Wms_reservoirarea>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}