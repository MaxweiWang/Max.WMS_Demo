using Max.Core.Entity;

namespace Max.Core.IServices
{
    public interface IWms_stockoutdetailServices : IBaseServices<Wms_stockoutdetail>
    {
        string PageList(string pid);
    }
}