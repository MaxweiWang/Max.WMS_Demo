using Max.Core.Dto;
using Max.Core.Entity;

namespace Max.Core.IServices
{
    public interface IWms_inventoryServices : IBaseServices<Wms_inventory>
    {
        string PageList(PubParams.InventoryBootstrapParams bootstrap);

        string SearchInventory(PubParams.InventoryBootstrapParams bootstrap);
    }
}