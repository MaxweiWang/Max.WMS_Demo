using Max.Core.Entity;

namespace IServices
{
    public interface IWms_stockoutdetailServices : IBaseServices<Wms_stockoutdetail>
    {
        string PageList(string pid);
    }
}