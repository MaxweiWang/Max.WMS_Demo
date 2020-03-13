using Max.Core.Dto;
using Max.Core.Entity;

namespace Max.Core.IServices
{
    public interface IWms_inventoryrecordServices : IBaseServices<Wms_inventoryrecord>
    {
        string PageList(PubParams.InventoryBootstrapParams bootstrap);
    }
}