using Max.Core.Entity;

namespace Max.Core.IServices
{
    public interface IWms_invmovedetailServices : IBaseServices<Wms_invmovedetail>
    {
        string PageList(string pid);
    }
}