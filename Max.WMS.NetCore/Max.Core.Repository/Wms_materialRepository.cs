using IRepository;
using SqlSugar;
using Max.Core.Entity;

namespace Repository
{
    public class Wms_materialRepository : BaseRepository<Wms_material>, IWms_materialRepository
    {
        public Wms_materialRepository(SqlSugarClient dbContext) : base(dbContext)
        {
        }
    }
}