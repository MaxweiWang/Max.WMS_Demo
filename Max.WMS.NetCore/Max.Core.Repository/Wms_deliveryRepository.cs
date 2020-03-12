using IRepository;
using SqlSugar;
using Max.Core.Entity;

namespace Repository
{
    public class Wms_deliveryRepository : BaseRepository<Wms_delivery>, IWms_deliveryRepository
    {
        public Wms_deliveryRepository(SqlSugarClient dbContext) : base(dbContext)
        {
        }
    }
}