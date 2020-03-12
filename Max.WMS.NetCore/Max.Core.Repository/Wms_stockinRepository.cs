using IRepository;
using SqlSugar;
using Max.Core.Entity;

namespace Repository
{
    public class Wms_stockinRepository : BaseRepository<Wms_stockin>, IWms_stockinRepository
    {
        public Wms_stockinRepository(SqlSugarClient dbContext) : base(dbContext)
        {
        }
    }
}