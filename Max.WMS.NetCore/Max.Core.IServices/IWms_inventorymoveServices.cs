using Max.Core.Entity;
using Max.Core.Utils.Pub;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_inventorymoveServices : IBaseServices<Wms_inventorymove>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);

        bool Auditin(long userId, long InventorymoveId);

        string PrintList(string InventorymoveId);
    }
}