using Max.Core.Entity;

namespace Max.Core.IServices
{
    public interface IWms_stockindetailServices : IBaseServices<Wms_stockindetail>
    {
        string PageList(string pid);
    }
}