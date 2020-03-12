using SqlSugar;
using Max.Core.Dto;
using Max.Core.Entity;

namespace IServices
{
    public interface IWms_stockoutServices : IBaseServices<Wms_stockout>
    {
        string PageList(PubParams.StockOutBootstrapParams bootstrap);

        string PrintList(string stockInId);

        DbResult<bool> Auditin(long userId, long stockOutId);
    }
}